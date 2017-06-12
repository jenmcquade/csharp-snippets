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
            var fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Orange");
            fruitList.Add("Date");

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            fruitList.Sort();
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            ReportOnFigs(fruitList);

        }

        static void ReportOnFigs(List<string> items)
        {
            string figReport =
                items.Contains("Fig", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are figs." :
                "No there are no figs";
            Console.WriteLine(figReport);
        }

    }
}
