using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, Amount, days, daysdriven, milesdriven;
            miles = 0.25;
            days = 20;
            Console.WriteLine("How many days are you going to rent the car for ");
            daysdriven = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many miles are you going to rent the car for ");
            milesdriven = Convert.ToDouble(Console.ReadLine());
            Amount = (days * daysdriven) + (miles * milesdriven);
            Console.WriteLine("The cost of the car rental equals $" + Amount);
            Console.ReadLine();





        }
    }
}
