using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VisualProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtOutput.Text = "I'm learning how to code in C#!";
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            Button myButton = (Button)sender;

            string name = myButton.Name;
            string type = myButton.GetType().Name;
            string label = myButton.Content.ToString();

            txtOutput.Text = "You clicked a " + type + " named " + name;
            txtOutput.Text += Environment.NewLine +
                "The button says " + label;
        }
    }
}
