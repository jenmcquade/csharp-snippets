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

            var f1 = new Fruit("Apple", 8.5, 3);
            produce.Add(f1);

            var f2 = new Fruit("Banana", 4.5, 7);
            produce.Add(f2);

            produce.Add(new Vegetable("Carrot", 4.1, 16));
            //((Vegetable)produce[2]).Name = "Carrot";
            //((Vegetable)produce[2]).Weight = 4.1;
            //((Vegetable)produce[2]).Quantity = 16;

            Console.WriteLine("There are " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }

        }

    }

    class Fruit
    {

        public Fruit()
        {
        }

        public Fruit(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;
        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }

    }

    class Vegetable
    {

        public Vegetable()
        {
        }

        public Vegetable(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }
    }
}
