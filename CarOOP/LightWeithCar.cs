using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LightWeithCar:Car,ILightWeightCar
    {
        int CountSeats;

        public LightWeithCar(int yearOfManuf, string model, string color, double cost, int countSeats, int mileAge = 0)
            :base( yearOfManuf,  model,  color, cost, mileAge)
        {
            CountSeats = countSeats;
        }

        public int GetSeatsCount()
        {
            return CountSeats;
        }

        public override void PrintDescription()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", Model, YearOfManuf, Color, Cost, CountSeats, MileAge);
        }
    }
}
