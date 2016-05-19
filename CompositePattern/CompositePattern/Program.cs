using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create structure of directories and files
            IComponent<string> logDir = new Composite<string>("log");
            for (int i = 1; i < 7; i++)
            {
                logDir.Add(new Component<string>(i + ".log"));
            }

            IComponent<string> backupDir = new Composite<string>("backup");
            for (char c = 'a'; c <= 'i'; c++)
            {
                backupDir.Add(new Component<string>(c + ".bck"));
            }

            IComponent<string> rootDir = new Composite<string>("/");
            rootDir.Add(logDir);
            rootDir.Add(backupDir);
            rootDir.Add(new Component<string>("readme.txt"));

            // Output structure
            Console.WriteLine(rootDir.Output());

            // Find an item in structure and output it
            Console.WriteLine(rootDir.Find("5.log").Output());

            Console.ReadLine();

        }
    }
}
