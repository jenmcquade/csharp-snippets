using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        const int Value1 = 12;
        const int Value2 = 24;

        static void Main(string[] args)
        {

            int total = Add(Value1, Value2);
            Console.WriteLine("Total: " + total);

            int result;
            AddToOutParam(Value1, Value2, out result);
            Console.WriteLine("The answer is " + result);
        }

        static int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        static void AddToOutParam(int value1, int value2, out int result)
        {
            result = value1 + value2;
        }
    }
}
