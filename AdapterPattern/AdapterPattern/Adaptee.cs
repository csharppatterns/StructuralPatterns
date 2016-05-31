using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // Existing way of implementation
    public class Adaptee
    {
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
