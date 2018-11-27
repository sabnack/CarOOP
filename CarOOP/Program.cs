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
            HeavyWeightCar car1 = new HeavyWeightCar(1998, "ZIL","Red",300000,300);
            HeavyWeightCar car2 = new HeavyWeightCar(2000, "Kamaz", "Yellow", 900000, 500);
            HeavyWeightCar car3 = new HeavyWeightCar(2000, "Kamaz", "Yellow", 900000, 500);
            HeavyWeightCar car4 = new HeavyWeightCar("Kraz", 900000, 500);
            Console.WriteLine(car1.GetYear());
            Console.WriteLine(car1.Equals(car2));
            Console.WriteLine(car2.Equals(car3));
            Console.WriteLine(car1.GetDiscountPrice());
            Console.WriteLine(car1.GetDiscountPrice("0000"));
            Console.WriteLine(car1.GetDiscountPrice("0001"));

            Console.WriteLine(car4.GetColor() + " " + car4.GetYear());
        }
    }
}
