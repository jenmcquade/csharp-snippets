using System;
using System.Windows;

namespace CodeRunner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public const int MeaningOfLife = 42;
        enum Flavors { DarkChocolate, Vanilla, Strawberry };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunCode(object sender, RoutedEventArgs e)
        {
            // Place code here
            Output("The meaning of life is " + MeaningOfLife);
            Output("My favorite flavor is " + Flavors.DarkChocolate);
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
