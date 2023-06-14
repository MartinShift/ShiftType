using ModelLibrary.JsonModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using TypeClient.ViewModels;

namespace TypeClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
            CheckTextInit();
            Loaded += WindowLoaded;
        }
        public string textofCheck = "";
        public string textofInput = "";
        private TextPointer[] CheckTextPointer;
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).Login.Execute(null);
        }
        private void CheckTextInit()
        {
            var context = DataContext as MainWindowViewModel;
            CheckTextBox.AppendText(context.Words);
            textofCheck = new TextRange(CheckTextBox.Document.ContentStart, CheckTextBox.Document.ContentEnd).Text;
            SaveCheckTextPointer();

            GetCheckTextRange(0, Brushes.BlueViolet);
            TextRange tr = new TextRange(CheckTextPointer[1], CheckTextPointer[textofCheck.Length - 2]);
            tr.ClearAllProperties();
            tr.ApplyPropertyValue(TextElement.ForegroundProperty, "#444444");
        }
        private void SaveCheckTextPointer()
        {
            CheckTextPointer = new TextPointer[textofCheck.Length - 2 + 1];
            FlowDocument document = CheckTextBox.Document;
            TextPointer txNext = document.ContentStart;
            for (int i = 0; i <= textofCheck.Length - 2; i++)
            {
                txNext = txNext.GetNextInsertionPosition(LogicalDirection.Forward);
                CheckTextPointer[i] = txNext;
            }
            for (int i = 0; i < textofCheck.Length - 2; i++)
            {
                TextRange tr = new TextRange(CheckTextPointer[i], CheckTextPointer[i + 1]);
                //Console.WriteLine(tr.Text);
            }
        }
        private void CheckDifferent(bool insert = true)
        {
            if (insert)
            {
                int nowIndex = textofInput.Length - 1;
                if (textofInput[nowIndex] != textofCheck[nowIndex])
                {
                    GetCheckTextRange(nowIndex, Brushes.Red);
                }
                else
                {
                    GetCheckTextRange(nowIndex, (Brush)new BrushConverter().ConvertFromString("#d1d0c5"));
                }

                if (textofInput.Length < textofCheck.Length - 2)
                {
                    GetCheckTextRange(textofInput.Length, Brushes.BlueViolet);
                }

            }
            else
            {
                GetCheckTextRange(textofInput.Length, Brushes.BlueViolet);
                int nextIndex = textofInput.Length + 1;
                if (nextIndex < textofCheck.Length - 2)
                {
                    GetCheckTextRange(nextIndex, (Brush)new BrushConverter().ConvertFromString("#444444"));
                }
            }
        }
        private void GetCheckTextRange(int n, Brush Foreground)
        {

            TextRange tr = new TextRange(CheckTextPointer[n], CheckTextPointer[n + 1]);
            tr.ClearAllProperties();
            tr.ApplyPropertyValue(TextElement.ForegroundProperty, Foreground);
            if (Foreground == Brushes.BlueViolet || Foreground == Brushes.Red)
            {
                tr.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            }
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
            {
                e.Handled = true;
            }
            if (e.Key == Key.Back)
            {
                e.Handled = true;
                if (textofInput.Length > 0)
                {
                    textofInput = textofInput.Substring(0, textofInput.Length - 1);
                    CheckDifferent(false);
                    if (textofCheck[textofInput.Length] == '\r')
                    {
                        textofInput = textofInput.Substring(0, textofInput.Length - 1);
                        CheckDifferent(false);
                    }
                }
                var context = DataContext as MainWindowViewModel;
                context.Input = textofInput;
                return;
            }
            if (e.Key == Key.Escape)
            {
                e.Handled = true;
                var context = DataContext as MainWindowViewModel;
                context.Reset();
                return;
            }
            if ((e.Key == Key.Return || e.Key == Key.Enter) && textofCheck[textofInput.Length] != '⏎')
            {
                e.Handled = true;
                return;
            }
            if (textofInput.Length >= textofCheck.Length - 2)
            {
                e.Handled = true;
                return;
            }
            if ( e.Key == Key.Tab || e.Key == Key.System)
            {
                e.Handled = true;
            }
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                var context = DataContext as MainWindowViewModel;
                e.Handled = true;
                textofInput = string.Concat(textofInput, " ");
                context.Input = textofInput;
                CheckDifferent();
            }
        }
        private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
             var context = DataContext as MainWindowViewModel;
            if (textofInput.Length == 0)
            {
                context.Timer.IsEnabled = true;
            }
            textofInput = string.Concat(textofInput, e.Text);
            context.Input = textofInput;

            CheckDifferent();
        }
        public void TestEnded()
        {
            Reset();
        }
        public void Reset()
        {
            var context = DataContext as MainWindowViewModel;
            textofInput = context.Input;
            CheckTextBox.Document = new FlowDocument();
            CheckTextInit();
        }
    }

}
