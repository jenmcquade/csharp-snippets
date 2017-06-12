using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingInterfaces
{
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }

    class Document : IStorable
    {
        private string name;
        private Boolean mNeedsSave = false;

        public Document(string s) {
            name = s;
            Console.WriteLine("Created a document with name '{0}'", s);
        }

        public void Save() {
            Console.WriteLine("Saving the document");
        }

        public void Load() {
            Console.WriteLine("Loading the document");
        }

        public Boolean NeedsSave {
            get { return mNeedsSave; }
            set { mNeedsSave = value; }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Document d = new Document("Test Document");


            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
