using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise10
{
    public class Dog
    {
        private int weight;
        private string name;

        public int Weight { get => weight; set => weight = value; }
        public string Name { get => name; private set => name = value; }

        public Dog(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }


    }
}