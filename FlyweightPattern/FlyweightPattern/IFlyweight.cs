using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FlyweightPattern
{
    public interface IFlyweight
    {
        void Load(string filename);
        void Display(PaintEventArgs e, int row, int col);
    }
}
