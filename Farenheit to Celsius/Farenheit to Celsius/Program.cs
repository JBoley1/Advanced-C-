using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Farenheit_to_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheit, celsius;
           

            Console.WriteLine("Enter the farenheit value you wish to convert to celsius ");
            farenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (farenheit - 32) * 5 / 9;
            Console.WriteLine("The entered farenheit equals this amount of degrees in celsius " + Math.Round(celsius,2));
            Console.ReadLine();

        }
    }
}
