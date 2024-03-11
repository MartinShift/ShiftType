using CommonLibrary.JsonModels;
using System.Windows;
using System.Windows.Documents;
using TypeClient.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;
namespace TypeClient
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ResultWindow(TypeTestResult result, List<int> stats)
        {
            InitializeComponent();
            DataContext = new ResultWindowViewModel(result, stats)
            {
                Window = this
            };
        }
        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Escape || e.Key == Key.Enter)
            {
                this.Close();
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
