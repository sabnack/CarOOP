﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class HeavyWeightCar : Car, IHeavyWeightCar
    {
        double LoadCapacity;

        public HeavyWeightCar(int yearOfManuf, string model, string color, double cost, double loadCapacity, int mileAge = 0)
            : base(yearOfManuf, model, color, cost, mileAge)
        {
            LoadCapacity = loadCapacity;
        }

        public HeavyWeightCar(string model, double cost, double loadCapacity, int mileAge = 0)

            : this(1930, model, "Red", cost, loadCapacity, mileAge)
        {
            Model = model;
            Cost = cost;
            LoadCapacity = loadCapacity;
            MileAge = mileAge;
        }

        public double GetLoadCapacity()
        {
            return LoadCapacity;
        }

        public override void PrintDescription()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", Model, YearOfManuf, Color, Cost, LoadCapacity, MileAge);  
        }
    }
}
