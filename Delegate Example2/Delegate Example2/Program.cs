using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example2
{
    public class Delegate
    { 
    public delegate void FirstDelegate();

    public void functionA()
    {
        Console.WriteLine("I am the First Function");
    }
    public void functionB()
    {
        Console.WriteLine("I am the Second Function");
    }
    public void functionC()
    {
        Console.WriteLine("I am the Third Function");
    }
}
class Program
    {
        static void Main(string[] args)
        {
        Delegate testingdelegate = new Delegate();
        //Instantiation
        Delegate.FirstDelegate f1 = new Delegate.FirstDelegate(testingdelegate.functionA);
        Delegate.FirstDelegate f2 = new Delegate.FirstDelegate(testingdelegate.functionB);
        Delegate.FirstDelegate f3 = new Delegate.FirstDelegate(testingdelegate.functionC);

        //Invocation 
        f1();
        f2();
        f3();

        Console.ReadLine();

    }
    }
}
