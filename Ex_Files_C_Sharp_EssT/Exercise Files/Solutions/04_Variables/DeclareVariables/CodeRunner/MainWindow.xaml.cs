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
            int i = 42;
            Output("The value is " + i);

            int meaningOfLife = new Int32();
            Output("The value is " + meaningOfLife);

            var implicitValue = 56L;
            Output("The value is " + implicitValue);
            Output("The variable's type is: " + implicitValue.GetType().ToString());

            byte byteValue = 255;
            Output("The byte value is " + byteValue);

            byteValue++;
            Output("The new byte value is " + byteValue);


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
