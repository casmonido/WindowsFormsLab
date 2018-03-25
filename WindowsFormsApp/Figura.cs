using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Figura
    {
        public string Kolor
        {
            get;
            set;
        }

        public string Typ
        {
            get;
            set;
        }

        public double Pole
        {
            get;
            set;
        }

        public WspolrzedneSrodka WspolrzedneSrodka
        {
            get;
            set;
        }

        public Figura(string kolor, string typ, double pole, WspolrzedneSrodka wspolrzedne)
        {
            Kolor = kolor;
            Typ = typ;
            Pole = pole;
            WspolrzedneSrodka = wspolrzedne;
        }
    }
}
