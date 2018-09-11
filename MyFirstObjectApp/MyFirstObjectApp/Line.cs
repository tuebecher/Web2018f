using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstObjectApp
{
    class Line
    {
        private Point a;
        private Point b;

        public Line(Point aPoint, Point anotherPoint)
        {
            this.a = aPoint;
            this.b = anotherPoint;
            // this.a = new Point(aPoint);
            //this.b = new Point(anotherPoint);
        }

        public void MoveX(int i)
        {
            this.a.MoveX(i);
            this.b.MoveX(i);
        }

        public override string ToString()
        {
            return a + "<-line->" + b;
        }
    }
}
