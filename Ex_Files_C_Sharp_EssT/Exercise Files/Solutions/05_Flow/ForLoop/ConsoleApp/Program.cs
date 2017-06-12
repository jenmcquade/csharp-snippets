using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Number: " + i);
            }


            string[] fruit = { "Apples", "Oranges", "Grapes" };
            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }

        }
    }
}
