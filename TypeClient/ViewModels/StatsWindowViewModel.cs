using CommonLibrary.JsonModels;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using Microsoft.Win32;
using My.BaseViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using TypeClient.Models;

namespace TypeClient.ViewModels
{
    public class StatsWindowViewModel : NotifyPropertyChangedBase
    {

        public StatsWindowViewModel(ClientViewModel model, List<ClientViewModel> leaderboard, bool isEditProfile)
        {
            IsEditProfile = isEditProfile ? Visibility.Visible : Visibility.Hidden;
            OnPropertyChanged(nameof(IsEditProfile));
            Client = model;
            Leaderboard = leaderboard;
            Last10Tests = Client.Results.Count >= 10 ? Client.Results.GetRange(Client.Results.Count - 10, 10) : Client.Results;
            TakeAScreenShotImage = new BitmapImage(new Uri("https://cdn4.iconfinder.com/data/icons/interface-2/100/1-512.png"));
            OnPropertyChanged(nameof(TakeAScreenShotImage));
            var results15s = Client.Results.Where(x => x.TimeSpent == 15);
            var results30s = Client.Results.Where(x => x.TimeSpent == 30);
            var results60s = Client.Results.Where(x => x.TimeSpent == 60);
            var results120s = Client.Results.Where(x => x.TimeSpent == 120);

            Best15SResult = GetmaxResult(results15s);
            Best30SResult = GetmaxResult(results30s);
            Best60SResult = GetmaxResult(results60s);
            Best120SResult = GetmaxResult(results120s);
            Client15SPlace = Leaderboard.OrderByDescending(x => GetmaxResult(x.Results.Where(x => x.TimeSpent == 15))?.Wpm).ToList().FindIndex(x => x.Login == Client.Login) + 1;
            Client30SPlace = Leaderboard.OrderByDescending(x => GetmaxResult(x.Results.Where(x => x.TimeSpent == 30))?.Wpm).ToList().FindIndex(x => x.Login == Client.Login) + 1;
            Client60SPlace = Leaderboard.OrderByDescending(x => GetmaxResult(x.Results.Where(x => x.TimeSpent == 60))?.Wpm).ToList().FindIndex(x => x.Login == Client.Login) + 1;
            Client120SPlace = Leaderboard.OrderByDescending(x => GetmaxResult(x.Results.Where(x => x.TimeSpent == 120))?.Wpm).ToList().FindIndex(x => x.Login == Client.Login) + 1;
            OnPropertyChanged(nameof(Best15SVisibility));
            OnPropertyChanged(nameof(Best30SVisibility));
            OnPropertyChanged(nameof(Best60SVisibility));
            OnPropertyChanged(nameof(Best120SVisibility));


        }
        public Visibility IsEditProfile { get; set; }
        public List<TypeTestResult> Last10Tests { get; set; }
        public BitmapImage TakeAScreenShotImage { get; set; }
        public List<ClientViewModel> Leaderboard { get; set; }
        public ClientViewModel Client { get; set; }
        public StatsWindow Window { get; set; }
        public TypeTestResult? Best15SResult { get; set; }
        public TypeTestResult? Best30SResult { get; set; }
        public TypeTestResult? Best60SResult { get; set; }
        public TypeTestResult? Best120SResult { get; set; }
        public Visibility Best15SVisibility { get => Best15SResult == null ? Visibility.Hidden : Visibility.Visible; }
        public Visibility Best30SVisibility { get => Best30SResult == null ? Visibility.Hidden : Visibility.Visible; }
        public Visibility Best60SVisibility { get => Best60SResult == null ? Visibility.Hidden : Visibility.Visible; }
        public Visibility Best120SVisibility { get => Best120SResult == null ? Visibility.Hidden : Visibility.Visible; }
        public int Client15SPlace { get; set; }
        public int Client30SPlace { get; set; }
        public int Client60SPlace { get; set; }
        public int Client120SPlace { get; set; }
        public ObservableCollection<int> Labels
        {
            get => new(Enumerable.Range(1, Client.Results.Count).Select(x => x + 1));
        }
        public Func<int, string> Formatter { get; set; } = value => value.ToString("N");
        public SeriesCollection ResultsChart
        {
            get
            {
                var result = new SeriesCollection();
                var results = new List<TypeTestResult>();
                if (IsTime15)
                {
                    results.AddRange(Client.Results.Where(x => x.TimeSpent == 15));
                }
                if (IsTime30)
                {
                    results.AddRange(Client.Results.Where(x => x.TimeSpent == 30));
                }
                if (IsTime60)
                {
                    results.AddRange(Client.Results.Where(x => x.TimeSpent == 60));
                }
                if (IsTime120)
                {
                    results.AddRange(Client.Results.Where(x => x.TimeSpent == 120));
                }
                results = results.OrderBy(x => x.Date).ToList();
                if (IsWpm)
                {
                    var chart = new LineSeries()
                    {
                        Values = new ChartValues<int>(results.Select(x => x.Wpm)),
                        Stroke = Brushes.Green,
                        Title = "Wpm"
                    };
                    result.Add(chart);
                }
                if (IsAcc)
                {
                    var accchart = new LineSeries()
                    {
                        Values = new ChartValues<int>(results.Select(x => x.Accuracy)),
                        Stroke = Brushes.Blue,
                        Title = "Acc"
                    };
                    result.Add(accchart);
                }
                if (IsErr)
                {
                    var errorchart = new LineSeries()
                    {
                        Values = new ChartValues<int>(results.Select(x => x.Errors)),
                        Stroke = Brushes.Red,
                        Title = "Errors"
                    };
                    result.Add(errorchart);
                }
                if (IsRaw)
                {
                    var timechart = new LineSeries()
                    {
                        Values = new ChartValues<int>(results.Select(x => x.Raw)),
                        Stroke = Brushes.Tan,
                        Title = "Raw Wpm"
                    };
                    result.Add(timechart);
                }
                return result;
            }
        }
        public int OverallWordsTyped { get => Client.Results.Select(x => x.Text.Length).Sum() / 5; }
        public int HightestWpm { get => Client.Results.Max(x => x.Wpm); }
        public int AverageWpm { get => (int)Client.Results.Average(x => x.Wpm); }
        public int AverageLast10Wpm { get => (int)Client.Results.GetRange(Last10Tests.Count - 10, 10).Average(x => x.Wpm); }

        public int HightestAcc { get => Client.Results.Max(x => x.Accuracy); }
        public int AverageAcc { get => (int)Client.Results.Average(x => x.Accuracy); }
        public int AverageLast10Acc { get => (int)Client.Results.GetRange(Last10Tests.Count - 10, 10).Average(x => x.Accuracy); }


        private TypeTestResult? GetmaxResult(IEnumerable<TypeTestResult> results)
        {
            return results.Count() == 0 ? null : results.MaxBy(x => x.Wpm);
        }
        public ICommand ChangeImage => new RelayCommand(x =>
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                var image = new BitmapImage(new Uri(openFileDialog.FileName));
                if (image != null)
                {
                    Client.Logo = image;
                    OnPropertyChanged(nameof(Client));

                }
            }
        });
        public ICommand ChangeProfile => new RelayCommand(x =>
        {
            var message = new DataMessage()
            {
                Data = JsonSerializer.Serialize(Client.Client),
                Type = MessageType.ChangeProfile
            };
            var response = Helper.SendToServer(message);
            switch (response.Type)
            {
                case MessageType.IncorrectEmailChange:
                    MessageBox.Show("Wrong Email!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case MessageType.ChangeProfile:
                    break;
            }

        }, x => Client != null);
        public ICommand ChangePassword => new RelayCommand(x =>
        {
            var window = new PasswordChangeWindow(Client.Client);
            window.ShowDialog();
        });
        public ICommand Logout => new RelayCommand(x =>
        {
            Window.Close();
            Client = null;
            OnPropertyChanged(nameof(Client));
        });

        private bool _IsWpm { get; set; } = true;
        public bool IsWpm { get => _IsWpm; set { _IsWpm = value; OnPropertyChanged(nameof(IsWpm)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsWpmBrush)); } }
        private bool _IsAcc { get; set; } = true;
        public bool IsAcc { get => _IsAcc; set { _IsAcc = value; OnPropertyChanged(nameof(IsAcc)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsAccBrush)); } }
        private bool _IsErr { get; set; } = true;
        public bool IsErr { get => _IsErr; set { _IsErr = value; OnPropertyChanged(nameof(IsErr)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsErrBrush)); } }
        private bool _IsRaw { get; set; } = true;
        public bool IsRaw { get => _IsRaw; set { _IsRaw = value; OnPropertyChanged(nameof(IsRaw)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsRawBrush)); } }
        private bool _IsTime15 { get; set; } = true;

        public bool IsTime15 { get => _IsTime15; set { _IsTime15 = value; OnPropertyChanged(nameof(IsTime15)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsTime15Brush)); } }
        private bool _IsTime30 { get; set; } = true;
        public bool IsTime30 { get => _IsTime30; set { _IsTime30 = value; OnPropertyChanged(nameof(IsTime30)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsTime30Brush)); } }
        private bool _IsTime60 { get; set; } = true;
        public bool IsTime60 { get => _IsTime60; set { _IsTime60 = value; OnPropertyChanged(nameof(IsTime60)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsTime60Brush)); } }
        private bool _IsTime120 { get; set; } = true;
        public bool IsTime120 { get => _IsTime120; set { _IsTime120 = value; OnPropertyChanged(nameof(IsTime120)); OnPropertyChanged(nameof(ResultsChart)); OnPropertyChanged(nameof(IsTime120Brush)); } }

        public Brush IsWpmBrush { get => (Brush)new BrushConverter().ConvertFromString(!IsWpm ? "#8C8C8C" : "#0f63b9"); }
        public Brush IsAccBrush { get => (Brush)new BrushConverter().ConvertFromString(!IsAcc ? "#8C8C8C" : "#0f63b9"); }
        public Brush IsErrBrush { get => (Brush)new BrushConverter().ConvertFromString(!IsErr ? "#8C8C8C" : "#0f63b9"); }
        public Brush IsRawBrush { get => (Brush)new BrushConverter().ConvertFromString(!IsRaw ? "#8C8C8C" : "#0f63b9"); }

        public Brush IsTime15Brush { get => (Brush)new BrushConverter().ConvertFromString(!IsTime15 ? "#8C8C8C" : "#0f63b9"); }
        public Brush IsTime30Brush { get => (Brush)new BrushConverter().ConvertFromString(!IsTime30 ? "#8C8C8C" : "#0f63b9"); }
        public Brush IsTime60Brush { get => (Brush)new BrushConverter().ConvertFromString(!IsTime60 ? "#8C8C8C" : "#0f63b9"); }
        public Brush IsTime120Brush { get => (Brush)new BrushConverter().ConvertFromString(!IsTime120 ? "#8C8C8C" : "#0f63b9"); }

        public ICommand SetWpm => new RelayCommand(x =>
        {
            IsWpm = !IsWpm;
        });
        public ICommand SetAcc => new RelayCommand(x =>
        {
            IsAcc = !IsAcc;
        });
        public ICommand SetErr => new RelayCommand(x =>
        {
            IsErr = !IsErr;
        });
        public ICommand SetRaw => new RelayCommand(x =>
        {
            IsRaw = !IsRaw;
        });
        public ICommand SetTime15 => new RelayCommand(x =>
        {
            IsTime15 = !IsTime15;
        });
        public ICommand SetTime30 => new RelayCommand(x =>
        {
            IsTime30 = !IsTime30;
        });
        public ICommand SetTime60 => new RelayCommand(x =>
        {
            IsTime60 = !IsTime60;
        });
        public ICommand SetTime120 => new RelayCommand(x =>
        {
            IsTime120 = !IsTime120;
        });
    }
}
