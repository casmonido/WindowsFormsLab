using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class WspolrzedneSrodka
    {
        public static WspolrzedneSrodka Parse(String str)
        {
            string[] xy = str.Split(new char[] { ';' });
            int x, y;
            int.TryParse(xy[0], out x);
            int.TryParse(xy[1], out y);
            return new WspolrzedneSrodka(x, y);
        }

        public string toString()
        {
            return X + "; " + Y;
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
        public WspolrzedneSrodka(string sx, string sy)
        {
            int x, y;
            int.TryParse(sx, out x);
            int.TryParse(sy, out y);
            this.Y = y;
            this.X = x;
        }
        public WspolrzedneSrodka()
        { }
    }
}
