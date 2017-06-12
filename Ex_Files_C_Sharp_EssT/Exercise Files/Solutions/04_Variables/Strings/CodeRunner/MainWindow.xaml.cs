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
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            Output("The value of charArray: " + charArray);

            string hello = new String(charArray);
            Output("The value of hello: " + hello);

            string helloUpper = hello.ToUpper();
            Output("The value of helloUpper: " + helloUpper);

            string sub = hello.Substring(3, 2);
            Output("The value of sub: " + sub);

            hello += " world";
            Output("The value of hello: " + hello);



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
