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

            // How many key/value pairs are there?
            Console.WriteLine("There are {0} key/value pairs\n", fileTypes.Count);

            // try adding an existing key
            try {
                fileTypes.Add(".htm", "Web page");
            }
            catch (ArgumentException e) {
                Console.WriteLine("Key already exists in Dictionary\n");
            }

            // try removing and then finding a key
            fileTypes.Remove(".css");
            Console.WriteLine("fileTypes contains CSS: {0}\n", fileTypes.ContainsKey(".css"));

            // Dump the contents of the Dictionary
            Console.WriteLine("Dumping Dictionary contents:");
            foreach (KeyValuePair<string, string> kvp in fileTypes) {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("\nHit Enter to continue...");
            Console.ReadLine();
        }
    }
}
