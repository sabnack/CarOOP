﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LightWeithCar:Car,ILightWeightCar
    {
        int CountSeats;

        public LightWeithCar(int yearOfManuf, string model, string color, double cost, int countSeats)
            :base( yearOfManuf,  model,  color, cost)
        {
            CountSeats = countSeats;
        }

        public int GetSeatsCount()
        {
            return CountSeats;
        }
    }
}