using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(3,5), 14);
            Console.WriteLine(c.ToString());
            Console.WriteLine("Diameter:" + c.Diameter);
            Console.WriteLine("Area:" + c.Area);
            Console.ReadLine();


            Point p = new Point();


            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("my first point is " + p1.ToString());
            Console.WriteLine("my second point is " + p2);

            p1.IncrementX();

            Console.WriteLine("first after increment x: " + p1);
            p1.IncrementX();
            p1.IncrementX();
            p1.IncrementX();
            p1.IncrementX();
            Console.WriteLine("first after more increments: " + p1);

            p2.SetCoords(2, 7);
            Console.WriteLine("p1:" + p1 + " p2:" + p2);

            Point p3 = new Point(5, 67);
            Console.WriteLine("p1:" + p1 + " p2:" + p2+ " p3:"+p3);


            Line myLine = new Line(p1, p3);
            Console.WriteLine("myLine is: " + myLine);
            p1.IncrementX();
            Console.WriteLine("myLine is: " + myLine);

            myLine.MoveX(-2);
            Console.WriteLine("myLine is: " + myLine);

        }


    }
}
