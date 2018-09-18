using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plus operator: " + Math.Add(2, 3));
            Console.WriteLine("div operator: " + Math.Divide(2, 3));

            Book b1 = new Book( // example with publisher given
                "Programming C# 3.0", 
                "Jesse Liberty and Donald Xie",
                "9780596527433",
                "O’Reilly");
            Book b2 = new Book( // no publisher given
                "C# 3.0 In a Nutshell", 
                "Joseph Albahari and Ben Albahari", 
                "9780596527570");

            b1.DisplayBook();
            b2.DisplayBook();

            b1.Author = "Peter";
            // b1.Title = "asdf";
            b1.DisplayBook();


            Console.WriteLine("Book1 title: "+b1.Title);


        }
    }
}
