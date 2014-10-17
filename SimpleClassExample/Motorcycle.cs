﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        // New members to represent the name of the driver.
        public string driverName;
        public void SetDriverName(string name)
        {
            driverName = name;
        }

        // Constructor chaining.
        public Motorcycle()
        {
            Console.WriteLine("In default ctor");
        }

        public Motorcycle(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("In ctor taking an int");
        }

        public Motorcycle(string name)
            : this(0, name)
        {
            Console.WriteLine("In ctor taking a string");
        }

        // This is the 'master' constructor that does all the real work.
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }
    }
}
