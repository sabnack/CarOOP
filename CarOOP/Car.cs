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

        public Car(int yearOfManuf, string model, string color, double cost)
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
