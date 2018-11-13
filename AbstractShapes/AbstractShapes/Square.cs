using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbstractShapes
{
    public class Square : Rectangle
    {
        public Square(string id, Point refPoint, string color, int sideLength) 
            : base (id, refPoint, color, sideLength, sideLength)
        {
               
        }
    }
}