using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LightWeithCar:Car,ILightWeightCar
    {
        private int _countSeats;
        private readonly double _baseDiscount = 0.1;
        private const double _monthDiscount = 0.2;
        private const int _month = 12;

        public LightWeithCar(int yearOfManuf, string model, string color, double cost, int countSeats, int mileAge = 0)
            :base( yearOfManuf,  model,  color, cost, mileAge)
        {
            _countSeats = countSeats;
        }

        public int GetSeatsCount()
        {
            return _countSeats;
        }

        public override void PrintDescription()
        {

            Console.WriteLine("{0} {1} {2} {3} {4} {5}", Model, YearOfManuf, Color, Cost, _countSeats, MileAge);
        }

        public override double GetDiscountPrice()
        {
            int.TryParse(DateTime.Now.Month.ToString(), out int monthNow);

            if (_month == monthNow)
            {
                return Cost - Cost * _monthDiscount;
            }
            else
            {
                return Cost - (Cost * _baseDiscount + 2 * monthNow);
            }
        }
    }
}
