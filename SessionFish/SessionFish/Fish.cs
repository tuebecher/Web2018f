using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionFish
{
    public class Fish
    {
        public string Type { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }

        public Fish(string type, int length, int weight)
        {
            this.Type = type;
            this.Length = length;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return Type+" ("+Length+"cm, "+Weight+" gram)";
        }
    }
}