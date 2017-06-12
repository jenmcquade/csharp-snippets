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

            var inventory = new Dictionary<string, double>();

            inventory.Add("Figs", 56);
            inventory.Add("Apples", 23);
            inventory.Add("Oranges", 12);

            var keys = inventory.Keys;

            Console.WriteLine("Number of items: " + keys.Count);

            foreach (var key in keys)
            {
                Console.WriteLine(key + ": " + inventory[key]);
            }

            string[] keysArray = keys.ToArray();
            Array.Sort(keysArray);

            foreach (var key in keysArray)
            {
                Console.WriteLine(key + ": " + inventory[key]);
            }

            double value;
            if (inventory.TryGetValue("Figs", out value))
            {
                Console.WriteLine("Figs inventory: " + value);
            }
            else
            {
                Console.WriteLine("Figs inventory not available");
            }
        }

    }
}
