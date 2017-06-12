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
            var produce = new List<object>();

            var f1 = new Fruit();
            produce.Add(f1);

            var f2 = new Fruit();
            produce.Add(f2);

            produce.Add(new Vegetable());

            Console.WriteLine("There are " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }

        }

    }

    class Fruit
    {

    }

    class Vegetable
    {

    }
}
