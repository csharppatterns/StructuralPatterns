using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Before the new standard, precise value: ");
            Adaptee first = new Adaptee();
            Console.WriteLine(first.Divide(5, 3));

            Console.Write("Moving to the new standard: ");
            ITarget second = new Adapter();
            Console.WriteLine(second.DivideRound(5, 3));

            Console.ReadLine();

        }
    }
}
