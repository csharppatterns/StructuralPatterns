using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program : HelpDeskSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern");

            HelpDeskProxy userA = new HelpDeskProxy();
            userA.CreateTicket("I forgot my password.");

            Console.WriteLine();
            string userName = "userB";
            Portal userB = new Portal(new OpenHelpDeskProxy(userName));
            userB.CreateTicket("Internet connection is too slow.");

            Console.ReadLine();
        }
    }
}
