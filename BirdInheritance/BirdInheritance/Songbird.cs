using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirdInheritance
{
    public class Songbird : Bird
    {
        private int numberOfSongs;

        public int NumberOfSongs
        {
            get { return numberOfSongs; }
            set { numberOfSongs = value; }
        }

        public Songbird(string species, string color, int numberOfSongs) 
            : base(species, color)
        {
            this.NumberOfSongs = numberOfSongs;
        }

        public override string SayTweet()
        {
            return "sing sing singeling";
        }

        public string CallTheParentToString()
        {
            return base.ToString();
        }

        public override string ToString()
        {
            return base.ToString()+" and it knows "+NumberOfSongs+" songs";
        }
    }
}