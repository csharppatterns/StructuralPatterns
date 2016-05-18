using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    // Bridge
    interface IBridge
    {
        void CreateTicket(string message);
    }
}