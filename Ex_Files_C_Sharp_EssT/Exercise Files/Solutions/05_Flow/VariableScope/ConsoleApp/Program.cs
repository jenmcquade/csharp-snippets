using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static public int localField = 15;

        static void Main(string[] args)
        {
            int localVar = 1;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("value of localVar: " + localVar);
                localVar++;
            }

            CustomMethod();
        }

        static void CustomMethod()
        {
            Console.WriteLine("value of localField: " + localField);
        }
    }
}
