using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdInheritance
{
    public class Owl : Bird
    {
        public int NumOfMiceCaught { get; private set; }

        public Owl(string species, string color) : base(species, color)
        {
            NumOfMiceCaught = 0;
        }

        public void ChangeColor(string newColor)
        {
            this.Color = newColor;
        }


    }
}