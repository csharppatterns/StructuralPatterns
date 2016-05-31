using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Implementing new standard via existed implementation
    public class Adapter : Adaptee, ITarget
    {
        public string DivideRound(int a, int b)
        {
            return "Round " + (int)System.Math.Round(Divide(a, b));
        }
    }
}
