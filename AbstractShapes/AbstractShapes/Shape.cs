using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbstractShapes
{
    public abstract class Shape
    {
        public string Id { get; set; }
        public Point RefPoint { get; set; }
        public String Color { get; set; }

        public Shape(string id, Point referencePoint, string color)
        {
            Id = id;
            RefPoint = referencePoint;
            Color = color;
        }

        public string GetColor()
        {
            return Color;
        }

        public abstract double GetArea();
        public abstract double GetCircumference();
        public abstract double GetWidth();
        public abstract double GetHeight();

        public override string ToString()
        {
            return "[" + Id + ": refpoint=" + RefPoint.ToString() + " area=" + GetArea() + " circ=" + GetCircumference() + "]";
        }
    }
}