using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstObjectApp
{
    class Point
    {
        private int x;
        private int y;



        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(int xCoord, int yCoord)
        {
            this.x = xCoord;
            this.y = yCoord;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public void SetCoords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void IncrementX()
        {
            x++;
        }

        public void MoveX(int i)
        {
            // this.x += i;
            this.x = this.x + i;
        }
        public void MoveY(int i)
        {
            this.y = this.y + i;
        }

        public void Add(Point p)
        {
            this.MoveX(p.x);
            this.MoveY(p.y);
        }


        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }


    }
}
