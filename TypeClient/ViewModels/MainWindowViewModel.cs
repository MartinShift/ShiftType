using CommonLibrary.JsonModels;
using ModelLibrary.JsonModels;
using My.BaseViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using TypeClient.Models;

namespace TypeClient.ViewModels
{
    public class MainWindowViewModel : NotifyPropertyChangedBase
    {
        public MainWindowViewModel(MainWindow window)
        {
            Stats = new();
            LanguageList = Directory.GetFiles("Languages").Select(x => Path.GetFileName(x).Replace("_", " ").Replace(".json","")).ToList();
            _SelectedLanguage = LanguageList.First(x=> x.Contains("English"));
            
            TimeSeconds = 15;
            SetTimeButtonColor();
            Timer15SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer15SBrush));
            Time = TimeSpan.FromSeconds(TimeSeconds);
            SecondsLeft = Time.TotalSeconds.ToString();
            Window = window;
            Timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                Time -= TimeSpan.FromSeconds(1);
                SecondsLeft = Time.TotalSeconds.ToString();
                Stats.Add(TypeHelper.CountWPM(Input, Words, TimeSeconds - (int)Time.TotalSeconds));
                if (Time == TimeSpan.Zero)
                {
                    Timer.Stop();
                    Stats.Add(TypeHelper.CountWPM(Input, Words, TimeSeconds - (int)Time.TotalSeconds));
                    Stats.RemoveAt(0);
                    TestEnded();
                }

            }, Application.Current.Dispatcher);
            Timer.IsEnabled = false;
            LogoutImage = new BitmapImage(new Uri("https://cdn4.iconfinder.com/data/icons/interface-2/100/1-512.png"));
            LoginImage = new BitmapImage(new Uri("https://www.freeiconspng.com/thumbs/profile-icon-png/profile-icon-9.png"));
            LeaderboardImage = new BitmapImage(new Uri("https://icones.pro/wp-content/uploads/2021/05/symbole-de-la-couronne-grise.png"));
            GenerateWords();
            Task.Run(async () =>
            {
                await LeaderboardWorker();
            });

        }
        //Profile
        private ClientViewModel? _Client { get; set; }
        public ClientViewModel? Client
        {
            get => _Client;
            set
            {
                _Client = value;
                OnPropertyChanged(nameof(Client));
                OnPropertyChanged(nameof(UserName));
                OnPropertyChanged(nameof(LogoutVisibility));
                OnPropertyChanged(nameof(LoginVisibility));
            }
        }
        public string UserName { get => Client != null ? Client.Nickname : "Guest"; }
        public BitmapImage LogoutImage { get; set; }
        public BitmapImage LoginImage { get; set; }
        public BitmapImage LeaderboardImage { get; set; }
        //

        //Timer
        private string _SecondsLeft { get; set; } = "";
        public string SecondsLeft { get => _SecondsLeft; set { _SecondsLeft = value; OnPropertyChanged(nameof(SecondsLeft)); } }
        public DispatcherTimer Timer { get; set; }
        public TimeSpan Time { get; set; }
        public int TimeSeconds { get; set; }
        //

        //TypingTest
        private bool _isPopupOpen;
        public bool IsPopupOpen
        {
            get { return _isPopupOpen; }
            set
            {
                _isPopupOpen = value;
                OnPropertyChanged(nameof(IsPopupOpen));
            }
        }

        public Modes CurrentMode { get; set; }
        public string Words { get; set; }
        public List<int> Stats { get; set; }
        public string Input
        {
            get; set;
        } = "";
        private string _SelectedLanguage { get; set; }
        public string SelectedLanguage
        {
            get => _SelectedLanguage;
            set
            {
                _SelectedLanguage = value;
                OnPropertyChanged(nameof(SelectedLanguage));
                IsPopupOpen = false;
                Reset();
            }
        }
        public List<string> LanguageList { get; set; }
        public List<ClientViewModel> Leaderboard { get; set; }
        //

        //Window
        public MainWindow Window { get; set; }
        //

        //Visibility
        public Visibility LogoutVisibility { get => Client != null ? Visibility.Visible : Visibility.Hidden; }
        public Visibility LoginVisibility { get => Client == null ? Visibility.Visible : Visibility.Hidden; }
        //
        //Colors
        public Brush TimeModeBrush { get; set; }
        public Brush Timer15SBrush { get; set; }
        public Brush Timer30SBrush { get; set; }
        public Brush Timer60SBrush { get; set; }
        public Brush Timer120SBrush { get; set; }
        //

        //Commands
        public ICommand SetTimeMode => new RelayCommand(x =>
        {

            TimeSeconds = 15;
            CurrentMode = Modes.Time;
            SetTimeButtonColor();
        });
        public ICommand Logout => new RelayCommand(x =>
        {
            Client = null;
        });
        public ICommand Submit => new RelayCommand(x =>
        {

        });
        public ICommand Register => new RelayCommand(x =>
        {
            var window = new RegisterWindow();
            window.ShowDialog();
            var context = window.DataContext as RegisterWindowViewModel;
            if (context.Client != null)
            {
                Client = new(context.Client);
            }
        });
        public ICommand Login => new RelayCommand(x =>
        {
            var window = new LoginWindow();
            window.ShowDialog();
            var context = window.DataContext as LoginWindowViewModel;
            if (context.Client != null)
            {
                Client = new(context.Client);
            }
        });
        public ICommand GotoProfileOrLogin => new RelayCommand(x =>
        {
            if (Client == null)
            {
                Login.Execute(null);
            }
            else
            {
                GotoProfile();
            }
        });
        public ICommand LogoutOrLogin => new RelayCommand(x =>
        {
            if (Client != null)
            {
                Logout.Execute(null);
            }
            else
            {
                Login.Execute(null);
            }
        });
        public ICommand Set15STimer => new RelayCommand(x =>
        {
            TimeSeconds = 15;
            SetTimeButtonColor();
            Timer15SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer15SBrush));
            Reset();
        });
        public ICommand Set30STimer => new RelayCommand(x =>
        {
            TimeSeconds = 30;
            SetTimeButtonColor();
            Timer30SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer30SBrush));
            Reset();
        });
        public ICommand Set60STimer => new RelayCommand(x =>
        {
            TimeSeconds = 60;
            SetTimeButtonColor();
            Timer60SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer60SBrush));
            Reset();
        });
        public ICommand Set120STimer => new RelayCommand(x =>
        {
            TimeSeconds = 120;
            SetTimeButtonColor();
            Timer120SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer120SBrush));
            Reset();
        });
        public ICommand SelectLanguage => new RelayCommand(x =>
        {
            IsPopupOpen = true;
        });
        public ICommand OpenLeaderboards => new RelayCommand(x =>
        {
            var window = new LeaderboardWindow(Leaderboard, Client);
            window.ShowDialog();
        });
        private void SetTimeButtonColor()
        {
            Timer15SBrush = (Brush)new BrushConverter().ConvertFromString("#8C8C8C");
            Timer30SBrush = (Brush)new BrushConverter().ConvertFromString("#8C8C8C");
            Timer60SBrush = (Brush)new BrushConverter().ConvertFromString("#8C8C8C");
            Timer120SBrush = (Brush)new BrushConverter().ConvertFromString("#8C8C8C");
            OnPropertyChanged(nameof(Timer15SBrush));
            OnPropertyChanged(nameof(Timer30SBrush));
            OnPropertyChanged(nameof(Timer60SBrush));
            OnPropertyChanged(nameof(Timer120SBrush));
        }
        private void GotoProfile()
        {
            var window = new StatsWindow(Client, Leaderboard,true);
            window.ShowDialog();
            var context = window.DataContext as StatsWindowViewModel;
            Client = context.Client;
           
        }
        private void GenerateWords()
        {
            var json = File.ReadAllText($"Languages\\{SelectedLanguage.Replace(" ", "_")}.json");

            var words = JsonSerializer.Deserialize<List<string>>(json);
            var random = new Random();
            var sb = new StringBuilder();
            for(int i = 0; i < TimeSeconds*4;i++)
            {
                sb.Append(words[random.Next(0, words.Count - 1)]);
                sb.Append(' ');
            }
            Words = sb.ToString()[..^1];
        }
        private void TestEnded()
        {
            Input = Window.textofInput;
            var result = new TypeTestResult()
            {
                Client = Client == null ? null : Client.Client,
                Text = Input,
                TimeSpent = TimeSeconds,
                Wpm = TypeHelper.CountWPM(Input, Words, TimeSeconds),
                Errors = TypeHelper.CountErrors(Input, Words),
                Accuracy = (int)((double)Input.Length / (TypeHelper.CountErrors(Input, Words) + Input.Length) * 100),
                Date = DateTime.Now
            };
            if (Client != null && Input != "")
            {
                var message = new DataMessage()
                {
                    Data = JsonSerializer.Serialize(result),
                    Type = MessageType.TestResult
                };
                Task.Run(async () =>
                {
                Helper.SendToServer(message);
                });
                
            }
            var window = new ResultWindow(result, Stats);
            window.ShowDialog();
            Reset();
        }
        public void Reset()
        {
            Input = "";
            Stats.Clear();
            GenerateWords();
            Timer.IsEnabled = false;
            Time = TimeSpan.FromSeconds(TimeSeconds);
            SecondsLeft = Time.TotalSeconds.ToString();
            Window.Reset();
        }
        public async Task LeaderboardWorker()
        {
            while (true)
            {
                var message = new DataMessage()
                {
                    Data = "",
                    Type = MessageType.GetAllClients
                };
                var response = Helper.SendToServer(message);
                var json = JsonSerializer.Deserialize<List<JsonClient>>(response.Data);
                Leaderboard = json.Select(x => new ClientViewModel(x)).ToList();
                OnPropertyChanged(nameof(Leaderboard));
                Thread.Sleep(new TimeSpan(0, 1, 0));
            }
        }
        //
    }
}