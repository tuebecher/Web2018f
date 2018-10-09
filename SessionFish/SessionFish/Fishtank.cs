using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionFish
{
    public class Fishtank
    {
        private List<Fish> tank;

        public Fishtank()
        {
            tank = new List<Fish>();
        }

        public void AddFish(Fish f)
        {
            tank.Add(f);
        }

        public List<Fish> WhatIsInside()
        {
            return tank;
        }

    }
}