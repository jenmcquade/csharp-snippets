using System;
using System.Windows;

namespace CodeRunner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunCode(object sender, RoutedEventArgs e)
        {
            //Place code here
            char c1 = 'a';
            Output("The value of c1 is " + c1);

            char c2 = '\u0062';
            Output("The value of c2 is " + c2);

            char symbol = '$';
            Output("Is number or letter? " + Char.IsLetterOrDigit(symbol));

        }

        private void Output(string value)
        {
            txtOutput.Text += value + Environment.NewLine;
        }

        private void ClearOutput(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}
