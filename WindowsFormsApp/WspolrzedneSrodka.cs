using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class WspolrzedneSrodka
    {
        public string toString()
        {
            return X + ", " + Y;
        }

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

        public WspolrzedneSrodka(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }
    }
}
