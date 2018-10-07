using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Scooter scoot = new Scooter();
            scoot.ScooterType();

            Car car = new Car();
            car.CarType();

            Console.ReadKey();
        }
    }
    class Tire
    {
        protected void TireType()
        {
            Console.WriteLine("This is a tire without Tubes");
        }
    }
    class Scooter : Tire
    {
        public void ScooterType()
        {
            Console.WriteLine("The Color of the Scooter is Red");
            TireType();
        }
    }
    class Car : Tire
    {
        public void CarType()
        {
            Console.WriteLine("The type of Car is a : Ferrari");
            TireType();
        }
    }
}