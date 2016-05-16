using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class EmailWithAttachment : IEmail
    {
        IEmail email;

        public EmailWithAttachment(IEmail email)
        {
            this.email = email;
        }

        public string Write(string message)
        {
            return email.Write(message);
        }

        public string AddAttachment(string attachment)
        {
            return "Added attachment: " + attachment;
        }
    }
}
