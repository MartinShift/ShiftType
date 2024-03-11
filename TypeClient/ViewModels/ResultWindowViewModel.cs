using CommonLibrary.JsonModels;
using LiveCharts;
using LiveCharts.Wpf;
using My.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace TypeClient.ViewModels
{
    public class ResultWindowViewModel : NotifyPropertyChangedBase
    {
        public ResultWindowViewModel(TypeTestResult result, List<int> stats)
        {
            Wpm = result.Wpm;
            Errors = result.Errors;
            Accuracy = result.Accuracy;
            Raw = result.Raw;
            Seconds = result.TimeSpent;
            Charachters = result.Text.Length;
            Stats = stats;
            OnPropertyChanged(nameof(Labels));
            OnPropertyChanged(nameof(ResultsChart));
            TakeAScreenShotImage = new BitmapImage(new Uri("https://cdn4.iconfinder.com/data/icons/interface-2/100/1-512.png"));
            OnPropertyChanged(nameof(TakeAScreenShotImage));
        }
        public ResultWindow Window { get; set; }
        public int Raw { get; set; }
        public int Wpm { get; set; }
        public int Accuracy { get; set; }
        public int Seconds { get; set; }
        public List<int> Stats { get; set; }
        public int Errors { get; set; }
        public int Charachters { get; set; }
        public BitmapImage TakeAScreenShotImage { get; set; }
        public ObservableCollection<int> Labels
        {
            get => new(Enumerable.Range(1,Stats.Count).Select(x=> x+1));
        }
        public Func<int, string> Formatter { get; set; } = value => value.ToString("N");
        public SeriesCollection ResultsChart
        {
            get
            {
                var result = new SeriesCollection();

                var chart = new LineSeries()
                {
                    Values = new ChartValues<int>(Stats),

                    Title = "Wpm"
                };
                result.Add(chart);
                return result;
            }
        }
        public ICommand Exit => new RelayCommand(x =>
        {
            Window.Close();
        });
    }
}
