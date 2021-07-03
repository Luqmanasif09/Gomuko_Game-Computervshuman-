using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    enum COLOR { WHITE, RED, BLUE };
    class Cell:Button
    {
        public int row=0;
        public int col=0;
        public COLOR Occupy;
        public void setrow(int r)
        {
            row = r;
        }
        public void setcol(int c)
        {
            col = c;
        }
        public Cell(int h, int w)
        {
            this.Height = h;
            this.Width = w;
            Occupy = COLOR.WHITE;
        }
    }
}
