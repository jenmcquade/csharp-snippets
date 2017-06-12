using System;
using System.Windows;
using System.Windows.Controls;

namespace VisualCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool isNewEntry = true;
        double currentValue = 0;
        enum Operation { Add, Subtract, Multiply, Divide, Equals, Start, LastOp };
        Operation currentOperation = Operation.Start;

        public MainWindow()
        {
            InitializeComponent();
            txtOut.Text = currentValue.ToString();
        }

        private void BtnEntry_Click(object sender, RoutedEventArgs e)
        {
            //dummy value for trying to parse the entry string
            int result;

            //Get the value from the button label
            Button btn = (Button)sender;
            string value = btn.Content.ToString();

            //special handling for decimal point
            if (value.Equals(".")) {
                if (isNewEntry)
                {
                    return;
                }
                if (!txtOut.Text.Contains(".")) {
                    txtOut.Text += value;
                    isNewEntry = false;
                }
                return;
            }

            //try to parse entry as int; 
            //if successful, append to current entry
            if (Int32.TryParse(value, out result))
            {
                if (isNewEntry || txtOut.Text.Equals("0"))
                {
                    txtOut.Text = "";
                }
                txtOut.Text += value;
                isNewEntry = false;
            }
        }

        private void Calculate(Operation op)
        {
            double newValue = Double.Parse(txtOut.Text);
            double result;

            if (op != Operation.LastOp)
            {
                currentOperation = op;
            }

            switch (currentOperation)
            {
                case Operation.Add:
                    result = currentValue + newValue;
                    break;
                case Operation.Subtract:
                    if (currentValue == 0)
                    {
                        result = newValue;    
                    }
                    else
                    {
                        result = currentValue - newValue;
                    }
                    break;
                case Operation.Multiply:
                    if (currentValue == 0)
                    {
                        result = newValue;    
                    }
                    else
                    {
                        result = currentValue * newValue;
                    }
                    break;
                case Operation.Divide:
                    if (newValue == 0)
                    {
                        txtOut.Text = currentValue.ToString();
                        return;
                    }
                    else if (currentValue == 0)
                    {
                        currentValue = newValue;
                        txtOut.Text = "0";
                        return;
                    }
                    else
                    {
                        result = currentValue / newValue;
                    }
                    break;
                default:
                    return;
            }

            currentValue = result;
            txtOut.Text = result.ToString();
            isNewEntry = true;
        }

        // 4 event handlers for operations:
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Calculate(Operation.Add);
        }
        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            Calculate(Operation.Subtract);
        }
        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            Calculate(Operation.Multiply);
        }
        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            Calculate(Operation.Divide);
        }

        //Clear the current results
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOut.Text = "0";
            currentValue = 0;
            isNewEntry = true;
        }

        //Handle the Equals button
        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            Calculate(Operation.LastOp);
        }

    }
}
