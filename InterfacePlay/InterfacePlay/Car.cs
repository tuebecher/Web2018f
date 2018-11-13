using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfacePlay
{
    public class Car : ISuperSortable
    {
        public string Brand { get; set; }
        public int NumOfWheels { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string brand, int numberOfWheels, int maxSpeed)
        {
            Brand = brand;
            NumOfWheels = numberOfWheels;
            MaxSpeed = maxSpeed;
        }

        public int CompareItems(object obj)
        {
            return MaxSpeed - ((Car)obj).MaxSpeed;
        }

        public override string ToString()
        {
            return Brand + " (" + NumOfWheels + " wheels - " + MaxSpeed + " km/h)";
        }
    }
}