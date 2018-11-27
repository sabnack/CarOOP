using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            HeavyWeightCar car1 = new HeavyWeightCar(model: "ZIL", yearOfManuf: 1998, cost: 300000, loadCapacity: 300, mileAge: 1000, color: "Red");
            HeavyWeightCar car2 = new HeavyWeightCar(2000, "Kamaz", "Yellow", 900000, 500);
            HeavyWeightCar car3 = new HeavyWeightCar(2000, "Kamaz", "Yellow", 900000, 500);
            HeavyWeightCar car4 = new HeavyWeightCar("Kraz", 900000, 500);
            LightWeithCar car5 = new LightWeithCar(2006, "Vaz", "Grey", 75000, 5);
            Console.WriteLine(car1.GetYear());
            Console.WriteLine(car1.Equals(car2));
            Console.WriteLine(car2.Equals(car3));
            Console.WriteLine(car1.GetDiscountPrice());
            Console.WriteLine(car1.GetDiscountPrice("0000"));
            Console.WriteLine(car1.GetDiscountPrice("0001"));
            Console.WriteLine("Discount");
            Console.WriteLine(car5.GetDiscountPrice());

            Console.WriteLine(car4.GetColor() + " " + car4.GetYear());

            car4.PrintDescription();

            Console.WriteLine(car1 > car2);
            Console.WriteLine(car1 < car2);
            Console.WriteLine(Car.CountCars());
            Console.WriteLine(car1.GetMileAge());
            Console.WriteLine(car2.GetMileAge());

            Console.WriteLine(car5.GetCarAge());
        }
    }
}
