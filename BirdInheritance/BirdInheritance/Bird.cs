using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdInheritance
{
    public class Bird
    {
        private string species;
        private string color;

        public string Species
        {
            get { return species; }
            private set { species = value; }
        }

        public string Color
        {
            get { return color; }
            protected set { color = value; }
        }

        public Bird(string species, string color)
        {
            this.Species = species;
            this.Color = color;
        }

        public virtual string SayTweet()
        {
            return "chirp chirp";
        }

        public override string ToString()
        {
            return "The " + Species + " is " + Color+" and it tweets "+SayTweet();
        }
    }
}