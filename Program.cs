using System;

namespace inclass
{
    class Car
    {
        string color;
        string make;
        public static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.color = "Blue";
            car1.make = "Ford";

            Car car2 = new Car();
            car2.color = "Red";
            car2.make = "Hyundai";

            Console.WriteLine(car1.color + " " +car1.make);
        }
    }
}
