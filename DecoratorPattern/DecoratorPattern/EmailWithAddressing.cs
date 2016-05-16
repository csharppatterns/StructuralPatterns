using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class EmailWithAddressing : IEmail
    {
        IEmail email;
        string recipient;

        public EmailWithAddressing(IEmail email, string recipient = null)
        {
            this.email = email;
            this.recipient = recipient;
        }

        public string Write(string message)
        {
            string resultMessage = email.Write(message);
            if (String.IsNullOrEmpty(recipient))
            {
                resultMessage = "Dear Sir or Madam,\n" + resultMessage;
            } else
            {
                resultMessage = String.Format("Dear {0},\n", recipient) + resultMessage;
            }
            return resultMessage;
        }
    }
}
