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

            double value1 = 42;
            double value2 = 12;

            Output("Add: " + (value1 + value2));
            Output("Subtract: " + (value1 - value2));
            Output("Divide: " + (value1 / value2));
            Output("Multiply: " + (value1 * value2));
            Output("Remainder: " + (value1 % value2));

            value1++;
            Output("New value1: " + value1);

            Output("Value of value2 with decrementing: " + --value2);
            Output("New value of value2: " + value2);

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
