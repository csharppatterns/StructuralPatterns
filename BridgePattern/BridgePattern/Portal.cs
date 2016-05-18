using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // Abstraction
    class Portal
    {
        IBridge bridge;

        public Portal(IBridge aHelpDesk)
        {
            bridge = aHelpDesk;
        }

        public void CreateTicket(string message)
        {
            bridge.CreateTicket(message);
        }

    }
}
