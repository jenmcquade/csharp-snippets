using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get values to calculate
            double double1 = GetValue("Enter value 1: ");
            double double2 = GetValue("Enter value 2: ");

            //Declare variable to hold result
            double result = 0;

            //Do math operation
            while (true)
            {
                Console.Write("(A)dd (S)ubtract (M)ultiply (D)ivide : ");
                
                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch (operation.ToUpper()) {
                    case "A" :
                        result = CalcUtilities.Add(double1, double2);
                        break;
                    case "S":
                        result = CalcUtilities.Subtract(double1, double2);
                        break;
                    case "M":
                        result = CalcUtilities.Multiply(double1, double2);
                        break;
                    case "D":
                        result = CalcUtilities.Divide(double1, double2);
                        break;
                    default :
                        Console.WriteLine("Choose from supported operations");
                        continue;
                }
                Console.WriteLine("\nResult: " + result);
                Console.Read();
                break;
            }

        }

        private static double GetValue(string label)
        {
            //the value to be returned
            double value;

            //loop until you get a valid entry
            while (true)
            {
                Console.Write(label);
                string input = Console.ReadLine();
                if (Double.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Value can't be parsed as a number");
                }
            }
        }

    }
}
