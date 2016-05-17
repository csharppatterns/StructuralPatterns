using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program : HelpDeskSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern");

            HelpDeskProxy userA = new HelpDeskProxy();
            userA.CreateTicket("My printer doesn't work...");

            HelpDeskProxy userB = new HelpDeskProxy();
            userB.CreateTicket("I can't access my email...");

            Console.ReadLine();
        }
    }
}
