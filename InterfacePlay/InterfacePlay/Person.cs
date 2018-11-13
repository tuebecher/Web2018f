using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfacePlay
{
    public class Person : ISuperSortable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Person(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }

        public override string ToString()
        {
            return Name+" age "+Age+" is "+Height+"cm";
        }

        public int CompareItems(object obj)
        {
            if (Age > ((Person)obj).Age)
            {
                return 1; // this is the largest
            }
            else if (Age == ((Person)obj).Age)
            {
                return 0; // identical
            }
            else
            {
                return -1; // other is the largest
            }
        }
    }
}