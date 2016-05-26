using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyweightPattern
{
    public struct Flyweight : IFlyweight
    {
        Image pThumbnail;

        public void Load(string filename)
        {
            pThumbnail = new Bitmap("../../pictures/" + filename + ".jpg").
                GetThumbnailImage(100, 76, null, new IntPtr());            
        }

        public void Display(PaintEventArgs e, int row, int col)
        {
            e.Graphics.DrawImage(pThumbnail, col * 105 + 5, row * 120 + 40,
                pThumbnail.Width, pThumbnail.Height);
        }
    }
}
