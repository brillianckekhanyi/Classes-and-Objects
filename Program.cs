using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        static void Main(string[] args)
        {
            

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            Book book2 = new Book();
            book2.title = "Lord of rings";
            book2.author = "Tolkenin";
            book2.pages = 900;
            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.author);
            Console.ReadLine();
        }
    }
}
