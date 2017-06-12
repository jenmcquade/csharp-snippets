using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    interface IFoo
    {
        void SomeMethod();
    }
    interface IBar
    {
        void SomeMethod();
    }

    class FooBar : IFoo, IBar
    {
        void IFoo.SomeMethod() {
            Console.WriteLine("This is IFoo's SomeMethod");
        }
        void IBar.SomeMethod() {
            Console.WriteLine("This is IBar's SomeMethod");
        }
        public void SomeMethod() {
            Console.WriteLine("This is the class SomeMethod");
        }
    }

    class Program
    {
        static void Main(string[] args) {
            FooBar fb = new FooBar();
            fb.SomeMethod();

            IFoo ifoo = fb as IFoo;
            ifoo.SomeMethod();

            IBar ibar = fb as IBar;
            ibar.SomeMethod();

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
