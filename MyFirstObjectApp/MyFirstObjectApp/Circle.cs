using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstObjectApp
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public int Diameter
        {
            get { return GetDiameter(); }
        }

        public double Area
        {
            get { return GetArea(); }
        }

        public Circle(Point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        private int GetDiameter()
        {
            return 2*Radius;
        }

        private double GetArea()
        {
            return Math.PI * Radius*Radius;
        }

        public override string ToString()
        {
            return "Circle" + Center + "r" + Radius;
        }
    }
}
