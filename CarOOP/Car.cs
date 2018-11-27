using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Car
    {

        protected int YearOfManuf;
        protected string Model;
        protected string Color;
        protected double Cost;
        static private int _counterCars = 0;
        protected int MileAge;

        public Car(int yearOfManuf, string model, string color, double cost, int mileAge=0)
        {
            if (yearOfManuf > 1900 && yearOfManuf < 2020)
            {
                YearOfManuf = yearOfManuf;
            }
            else
            {
                YearOfManuf = 1900;
            }
            Model = model;
            Color = color;
            Cost = cost;
            _counterCars++;
            MileAge = mileAge;
        }

        static public int CountCars()
        {
           return _counterCars;
        }

        public int GetMileAge()
        {
            return MileAge;
        }

        public int GetYear()
        {
            return YearOfManuf;
        }

        public string GetModel()
        {
            return Model;
        }

        public string GetColor()
        {
            return Color;
        }

        public double GetCost()
        {
            return Cost;
        }

        public override bool Equals(object obj)
        {
            if (obj is Car)
            {
                Car car = (Car)obj;
                return GetYear() == car.GetYear() && GetModel() == car.GetModel();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return YearOfManuf.GetHashCode() ^ Model.GetHashCode();
        }

        public double GetDiscountPrice()
        {
            return Cost * 0.9;
        }

        public double GetDiscountPrice(string card)
        {
            if (card == "0000")
                return Cost * 0.8;
            if (card == "0001")
                return Cost * 0.7;
            return Cost * 0.9;
        }


        public abstract void PrintDescription();

        public static bool operator >(Car car1, Car car2)
        {
            return car1.Cost > car2.Cost;
        }

        public static bool operator <(Car car1, Car car2)
        {
            return car1.Cost < car2.Cost;
        }

    }
}
