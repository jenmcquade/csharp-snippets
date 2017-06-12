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

            try
            {
                string[] fruit = { "Apples", "Oranges", "Grapes"};
                for (int i = 0; i <= fruit.Length; i++)
                {
                    Console.WriteLine(fruit[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }
    }
}
