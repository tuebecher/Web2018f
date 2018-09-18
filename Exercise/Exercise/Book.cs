using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }

        public Book(string title, string author, string isbn)
        {
            this.Author = author;
            this.Title = title;
            this.Isbn = isbn;
            this.Publisher = "O'Reilly";
        }
        public Book(string title, string author, string isbn, string publisher)
        {
            this.Author = author;
            this.Title = title;
            this.Isbn = isbn;
            this.Publisher = publisher;
        }

        public void DisplayBook()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return Title + " : " + Author + " : " + Publisher + " : " + Isbn;
        }
    }
}

