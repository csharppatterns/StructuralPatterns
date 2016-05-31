using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLibrary
{
    internal class SubsystemA
    {
        internal string A1()
        {
            return "SubsystemA -> A1\n";
        }
        internal string A2()
        {
            return "SubsystemA -> A2\n";
        }
    }

    internal class SubsystemB
    {
        internal string B1()
        {
            return "SubsystemB -> B1\n";
        }
    }

    internal class SubsystemC
    {
        internal string C1()
        {
            return "SubsystemC -> C1\n";
        }
    }

    public static class Facade
    {
        static SubsystemA a = new SubsystemA();
        static SubsystemB b = new SubsystemB();
        static SubsystemC c = new SubsystemC();

        public static void Operation1()
        {
            Console.WriteLine("Operation1\n");
            Console.WriteLine(
                a.A1() +     
                a.A2() + 
                b.B1()
            );
        }

        public static void Operation2()
        {
            Console.WriteLine("Operation2\n");
            Console.WriteLine(
                b.B1() + 
                c.C1()
            );
        }
    }
}
