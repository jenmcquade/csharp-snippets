﻿using System;
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
            string[] fruit = { "Apples", "Oranges", "Grapes", "Avocados" };

            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }
        }
    }
}
