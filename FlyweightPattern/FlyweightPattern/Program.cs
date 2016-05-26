using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyweightPattern
{
    class Program
    {
        static FlyweightFactory album = new FlyweightFactory();
        static Dictionary<string, List<string>> groups = 
            new Dictionary<string, List<string>>();

        public void LoadGroups()
        {
            var myGroups = new[]
            {
                new
                {
                    Name = "Animals", Members = new [] { "Jellyfish", "Koala", "Penguins" }
                },
                new
                {
                    Name = "Flowers", Members = new [] { "Chrysanthemum", "Hydrangeas", "Tulips" }
                },
                new
                {
                    Name = "Places", Members = new [] { "Desert", "Lighthouse" }
                },
                new
                {
                    Name = "Favorite", Members = new [] { "Koala", "Penguins", "Tulips", "Lighthouse" }
                }
            };

            foreach (var g in myGroups)
            {
                groups.Add(g.Name, new List<string>());
                foreach (string filename in g.Members)
                {
                    groups[g.Name].Add(filename);
                    album[filename].Load(filename);
                }
            }
        }

        public void DisplayGroups(Object source, PaintEventArgs e)
        {
            int row = 0;
            foreach (string groupName in groups.Keys)
            {
                int col = 0;
                e.Graphics.DrawString(groupName,
                    new Font("Arial", 12),
                    new SolidBrush(Color.Black),
                    new Point(0, row * 120 + 10)
                );
                foreach (string filename in groups[groupName])
                {
                    album[filename].Display(e, row, col);
                    col++;
                }
                row++;
            }
        }

        public class Window : Form
        {
            public Window()
            {
                this.Height = 550;
                this.Width = 600;
                this.Text = "Picture Groups";
                Program program = new Program();
                program.LoadGroups();
                this.Paint += new PaintEventHandler(program.DisplayGroups);
            }
        }

        static void Main(string[] args)
        {
            Application.Run(new Window());
        }
    }
}
