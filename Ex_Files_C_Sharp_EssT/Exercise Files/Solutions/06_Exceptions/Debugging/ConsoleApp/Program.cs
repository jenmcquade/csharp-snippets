using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruit = { "Apples", "Oranges", "Grapes" };
            for (int i = 0; i <= fruit.Length; i++)
            {
                Debug.WriteLine("Value of i : " + i);
                Console.WriteLine(fruit[i]);
            }

        }
    }
}
