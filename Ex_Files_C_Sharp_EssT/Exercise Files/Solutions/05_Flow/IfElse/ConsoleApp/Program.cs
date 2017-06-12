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
            string input = Console.ReadLine();

            if (input.Equals("Hello", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You said hello!");
            }
            else if (input.Equals("Goodbye", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You said goodbye!");
            }
            else
            {
                Console.WriteLine("You said something else!");
            }
        }
    }
}
