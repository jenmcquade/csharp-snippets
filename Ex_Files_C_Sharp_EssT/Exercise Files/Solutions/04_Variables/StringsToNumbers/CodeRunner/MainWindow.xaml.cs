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
            string s = "255";
            int intFromString = Int32.Parse(s);
            Output("Value of intFromString: " + intFromString);

            int doubled = intFromString * 2;
            Output("Value of doubled: " + doubled);

            string s2 = "19.99";
            //double doubleFromString = Double.Parse(s2);
            //Output("Value of doubleFromString: " + doubleFromString);

            double doubleFromString;
            if (Double.TryParse(s2, out doubleFromString))
            {
                Output("Value of doubleFromString: " + doubleFromString);
            }
            else
            {
                Output("Couldn't parse the value!");
            }

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
