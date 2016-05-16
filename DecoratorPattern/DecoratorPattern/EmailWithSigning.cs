using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class EmailWithSigning : IEmail
    {
        IEmail email;

        public EmailWithSigning(IEmail email)
        {
            this.email = email;
        }

        public string Write(string message)
        {
            string resultMessage = email.Write(message);
            resultMessage += "\nYours sincerely";
            return resultMessage;
        }
    }
}
