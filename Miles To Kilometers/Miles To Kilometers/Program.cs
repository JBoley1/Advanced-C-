using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles, kilometers;
            kilometers = 1.6;
            Console.WriteLine("Enter how many miles you wish ");
            miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The amount of Kilometers that was converted from miles = {0}", (miles * kilometers) );
            Console.ReadLine();




        }
    }
}
