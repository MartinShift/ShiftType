using CommonLibrary.JsonModels;
using My.BaseViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace TypeClient.ViewModels
{
    public class LeaderboardWindowViewModel : NotifyPropertyChangedBase
    {

        public LeaderboardWindowViewModel(List<ClientViewModel> leaderboard, ClientViewModel current)
        {
            Leaderboard = leaderboard;
            Current = current;
            Leaders = new();
            Set15STimer.Execute(null);
        }
        public Brush Timer15SBrush { get; set; }
        public Brush Timer30SBrush { get; set; }
        public Brush Timer60SBrush { get; set; }
        public Brush Timer120SBrush { get; set; }
        public List<ClientViewModel> Leaderboard { get; set; }
        public ClientViewModel Current { get; set; }
        private Tuple<ClientViewModel, TypeTestResult, int> _Selected { get; set; }
        public Tuple<ClientViewModel, TypeTestResult, int> Selected
        {
            get => _Selected;
            set
            {
                _Selected = value; OnPropertyChanged(nameof(Selected));
                if (_Selected != null)
                {
                    var window = new StatsWindow(Selected.Item1, Leaderboard, false);
                    window.ShowDialog();
                }
            }
        }

        public ObservableCollection<Tuple<ClientViewModel, TypeTestResult, int>> Leaders { get; set; }

        public int TimeState { get; set; }

        public void LoadLeaders()
        {
            Leaders.Clear();
            var leaderboard = Leaderboard.OrderByDescending(x => x.Results.Where(x => x.TimeSpent == TimeState).MaxBy(x => x.Wpm)?.Wpm).ToList();
            leaderboard.ForEach(x =>
            {
                Leaders.Add(new(x, x.Results.Where(x => x.TimeSpent == TimeState).MaxBy(x => x.Wpm),leaderboard.FindIndex(y=> x.Login == y.Login) +1));
            });
            Leaders = new(Leaders.Where(x => x.Item2 != null));
            OnPropertyChanged(nameof(Leaders));
        }
        public ICommand Set15STimer => new RelayCommand(x =>
        {

            TimeState = 15;
            SetTimeButtonColor();
            Timer15SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer15SBrush));
            LoadLeaders();
        });
        public ICommand Set30STimer => new RelayCommand(x =>
        {
            TimeState = 30;
            SetTimeButtonColor();
            Timer30SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer30SBrush));
            LoadLeaders();
        });
        public ICommand Set60STimer => new RelayCommand(x =>
        {
            TimeState = 60;
            SetTimeButtonColor();
            Timer60SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer60SBrush));
            LoadLeaders();
        });
        public ICommand Set120STimer => new RelayCommand(x =>
        {
            TimeState = 120;
            SetTimeButtonColor();
            Timer120SBrush = (Brush)new BrushConverter().ConvertFromString("#0f63b9");
            OnPropertyChanged(nameof(Timer120SBrush));
            LoadLeaders();
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
    }
}
