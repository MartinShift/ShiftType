using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using TypeClient.ViewModels;

namespace TypeClient
{
    /// <summary>
    /// Interaction logic for StatsWindow.xaml
    /// </summary>
    public partial class StatsWindow : Window
    {
        public StatsWindow(ClientViewModel model,List<ClientViewModel> leaderboard, bool isEditProfile)
        {
            InitializeComponent();
            DataContext = new StatsWindowViewModel(model, leaderboard,isEditProfile)
            {
                Window = this
            };

        }

        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }
    }
}
