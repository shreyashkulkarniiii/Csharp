using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    using System;

    public class Vehicle1
    {

        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle1(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    public class Car : Vehicle1
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int speed, int numberOfDoors) : base(brand, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }
    public class Bike : Vehicle1
    {
        public string BikeType { get; set; }
        public Bike(string brand, int speed, string bikeType) : base(brand, speed)
        {
            BikeType = bikeType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bike Type: {BikeType}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 120, 4);
            Console.WriteLine("Car Information:");
            car.DisplayInfo();

            Console.WriteLine();

            Bike bike = new Bike("Harley-Davidson", 80, "Cruiser");
            Console.WriteLine("Bike Information:");
            bike.DisplayInfo();
        }
    }
}
