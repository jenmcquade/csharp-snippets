using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        enum Fruit { Apple, Orange, Fig };

        static void Main(string[] args)
        {
            var thisFruit = Fruit.Apple;
            switch (thisFruit)
            {
                case Fruit.Apple:
                    Console.WriteLine("You chose Apple");
                    break;

                case Fruit.Orange:
                    Console.WriteLine("You chose Orange");
                    break;

                case Fruit.Fig:
                    Console.WriteLine("You chose Fig");
                    break;
                
                default:
                    Console.WriteLine("You chose something else");
                    break;
            }

        }
    }
}
