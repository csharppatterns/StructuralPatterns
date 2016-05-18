using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class HelpDeskSystem
    {

        // The Subject
        private class HelpDesk
        {
            static SortedList<string, HelpDesk> users = new SortedList<string, HelpDesk>();
            string user;

            public static bool IsUnique(string userName)
            {
                return !users.ContainsKey(userName);
            }

            internal HelpDesk(string userName)
            {
                user = userName;
                users[userName] = this;
            }

            internal void CreateTicket(string message)
            {
                Console.WriteLine(String.Format("{0} created new ticket: {1}", user, message));
            }

        }

        // The Proxy
        public class HelpDeskProxy
        {
            HelpDesk myHelpDesk;
            string user;
            string password;
            bool loggedIn = false;

            void Register()
            {
                Console.WriteLine("\nLet's register your HelpDesk account");
                do
                {
                    Console.WriteLine("All HelpDesk accounts must be unique");
                    Console.Write("Type in a user name: ");
                    user = Console.ReadLine();
                } while (!HelpDesk.IsUnique(user));
                Console.Write("Type in a password: ");
                password = Console.ReadLine();
                Console.WriteLine("Thanks for registering with HelpDesk");
            }

            bool Authenticate()
            {
                Console.Write(String.Format("Welcome {0}. Please type in your password: ", user));
                string supplied = Console.ReadLine();
                if (password == supplied)
                {
                    loggedIn = true;
                    Console.WriteLine("Logged into HelpDesk");
                    if (myHelpDesk == null)
                    {
                        myHelpDesk = new HelpDesk(user);
                    }
                    return true;
                }
                Console.WriteLine("Incorrect password");
                return false;
            }

            void Check()
            {
                if (!loggedIn)
                {
                    if (password == null)
                    {
                        Register();
                    }
                    if (myHelpDesk == null)
                    {
                        Authenticate();
                    }
                }
            }

            public void CreateTicket(string message)
            {
                Check();
                if (loggedIn)
                {
                    myHelpDesk.CreateTicket(message);
                }
            }

        }

        // New version of Proxy
        public class OpenHelpDeskProxy : IBridge
        {
            HelpDesk myOpenHelpDesk;
            static int usersCount;
            string user;

            public OpenHelpDeskProxy(string userName)
            {
                user = userName;
                usersCount++;
                myOpenHelpDesk = new HelpDesk(user + "-" + usersCount);
            }

            public void CreateTicket(string message)
            {
                myOpenHelpDesk.CreateTicket(message);
            }
        }
    }
}
