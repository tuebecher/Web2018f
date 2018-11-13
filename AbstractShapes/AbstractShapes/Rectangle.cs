using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbstractShapes
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(string id, Point refPoint, string color, int height, int width) : base(id, refPoint, color)
        {
            Height = height;
            Width = width;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetCircumference()
        {
            return 2 * Width + 2 * Height;
        }

        public override double GetHeight()
        {
            return Height;
        }

        public override double GetWidth()
        {
            return Width;
        }
    }
}