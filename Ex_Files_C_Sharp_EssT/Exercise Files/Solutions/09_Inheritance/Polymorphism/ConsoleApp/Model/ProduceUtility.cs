using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    class ProduceUtility
    {

        public static double GetItemWeight(Produce item)
        {
            return item.Weight * item.Quantity;
        }

        public static double GetTotalWeight(List<Produce> produce)
        {
            double result = 0;
            foreach (var item in produce)
            {
                result += item.Weight * item.Quantity;
            }
            return result;
        }
    }
}
