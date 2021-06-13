using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MonopolyGame
{
    public class Dice
    {
        public int roll { get; private set; }
        public Dice(int roll)
        {
            this.roll = roll;
        }
        public void draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.Red);
            SolidBrush bl = new SolidBrush(Color.Blue);
            if (roll == 1)
            {
                g.FillEllipse(br, 33 - 10, 28 - 10, 20, 20);
            }
            else if (roll == 2)
            {
                g.FillEllipse(br, 33 - 20, 28 - 10, 20, 20);
                g.FillEllipse(br, 33, 28 - 10, 20, 20);
            }
            else if (roll == 3)
            {
                g.FillEllipse(bl, 0, 56 - 20, 20, 20);
                g.FillEllipse(bl, 33 - 10, 28 - 10, 20, 20);
                g.FillEllipse(bl, 67 - 20, 0, 20, 20);
            }
            else if (roll == 4)
            {
                g.FillEllipse(br, 13, 10, 20, 20);
                g.FillEllipse(br, 33, 10, 20, 20);
                g.FillEllipse(br, 13, 30, 20, 20);
                g.FillEllipse(br, 33, 30, 20, 20);
            }
            else if (roll == 5)
            {
                g.FillEllipse(bl, 10, 0, 20, 20);
                g.FillEllipse(bl, 36, 0, 20, 20);
                g.FillEllipse(bl, 10, 35, 20, 20);
                g.FillEllipse(bl, 36, 35, 20, 20);
                g.FillEllipse(br, 33 - 10, 28 - 10, 20, 20);
            }
            else if (roll == 6)
            {
                g.FillEllipse(bl, 2, 10, 20, 20);
                g.FillEllipse(bl, 25, 10, 20, 20);
                g.FillEllipse(bl, 47, 10, 20, 20);

                g.FillEllipse(bl, 2, 30, 20, 20);
                g.FillEllipse(bl, 25, 30, 20, 20);
                g.FillEllipse(bl, 47, 30, 20, 20);
                br.Dispose();
            }
        }
    }
}
