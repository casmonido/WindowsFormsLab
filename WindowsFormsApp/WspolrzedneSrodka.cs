using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class WspolrzedneSrodka
    {
        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        WspolrzedneSrodka(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }
    }
}
