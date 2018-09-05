using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int a = 25;
            int b = 10;
            Console.WriteLine("a+b=" + a + b);
            Console.WriteLine("a+b=" + (a + b));

            string s = "My string is here and i can write anything :-)";
            Console.WriteLine("s=" + s);

            // double is a float with 64 bits  (unprecise decimal type)
            double d1 = 23d;
            double d2 = 23.5;
            double d3 = d1 * d2;


            Console.WriteLine("d1*d2=" + d1 + "*" + d2 + "=" + d3);

            // precise decimal type
            decimal de1 = 23m;
            decimal de2 = 23.5m;
            Console.WriteLine("de1*de2=" + de1 + "*" + de2 + "=" + (de1 * de2));

            bool b1 = true;
            bool b2 = false || b1; // Boolean OR
            bool b3 = b1 && b2; // boolean AND
            Console.WriteLine("b3=" + b3);


            double d = 723.8;
            int i1 = (int)d;
            Console.WriteLine("double " + d + " cast (int)=" + i1);
            int i2 = Convert.ToInt32(d);
            Console.WriteLine("double " + d + " Convert.ToInt32=" + i2);
            long i3 = Convert.ToInt64(d);
            Console.WriteLine("double " + d + " Convert.ToInt64=" + i3);


            Console.WriteLine("Give me a number I can test?");
            string numString = Console.ReadLine();
            int num = Convert.ToInt32(numString);
            Console.WriteLine("Well, after extensive testing I found that:");
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is an even number");
            }
            else
            {
                Console.WriteLine(num + " is an odd number");
            }

            if (num > 0)
            {
                Console.WriteLine("and " + num + " is a positive number");
            }
            else if (num == 0)
            {
                Console.WriteLine("and " + num + " is ZERO");
            }
            else // not positive or zero => must be negative
            {
                Console.WriteLine("and " + num + " is a negative number");
            }



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
