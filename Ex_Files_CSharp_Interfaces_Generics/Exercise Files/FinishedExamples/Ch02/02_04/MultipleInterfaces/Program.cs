using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }

    class Document : IStorable, IEncryptable
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

        public void Encrypt() {
            Console.WriteLine("Encrypting the document");
        }

        public void Decrypt() {
            Console.WriteLine("Decrypting the document");
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

            d.Load();
            d.Encrypt();
            d.Save();
            d.Decrypt();
            d.NeedsSave = false;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
