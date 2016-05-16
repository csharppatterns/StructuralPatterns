using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern\n");
            IEmail email = new Email();

            Console.WriteLine("Basic Component:");
            Console.WriteLine(email.Write("How are you?"));
            Console.WriteLine();

            EmailWithAddressing addressedEmail = new EmailWithAddressing(email, "Bob");
            EmailWithSigning signedEmail = new EmailWithSigning(addressedEmail);
            EmailWithAttachment emailWithAttachment = new EmailWithAttachment(signedEmail);
            Console.WriteLine("Decorated Component:");
            Console.WriteLine(emailWithAttachment.Write("How are you?"));
            Console.WriteLine(emailWithAttachment.AddAttachment("Image"));

            Console.ReadLine();
        }
    }
}
