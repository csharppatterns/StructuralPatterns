using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Required standard
    public interface ITarget
    {
        string DivideRound(int a, int b);
    }
}
