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
            DateTime dt = new DateTime(2014, 1, 1);
            Output("The date is " + dt.ToString("MMMM d, yyyy"));

            DateTime now = DateTime.Now;
            Output("Now is " + now.ToString("MMMM d, yyyy"));

            DateTime anotherDay = dt.AddDays(-1);
            Output("The date is " + anotherDay.ToString("MMMM d, yyyy"));

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
