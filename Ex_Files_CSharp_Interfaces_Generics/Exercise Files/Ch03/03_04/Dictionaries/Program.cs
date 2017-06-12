using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args) {
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();
            fileTypes.Add(".txt", "Text File");
            fileTypes.Add(".htm", "HTML Web Page");
            fileTypes.Add(".html", "HTML Web Page");
            fileTypes.Add(".css", "Cascading Style Sheet");
            fileTypes.Add(".xml", "XML Data");


            Console.WriteLine("\nHit Enter to continue...");
            Console.ReadLine();
        }
    }
}
