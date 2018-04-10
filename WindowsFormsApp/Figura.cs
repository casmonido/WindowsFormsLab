using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Figura
    {
        public ColorEnum Kolor
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

        public string Etykieta
        {
            get;
            set;
        }

        public WspolrzedneSrodka WspolrzedneSrodka
        {
            get;
            set;
        }

        public Figura(ColorEnum kolor, string typ, double pole, 
            WspolrzedneSrodka wspolrzedne, string etykieta)
        {
            Kolor = kolor;
            Typ = typ;
            Pole = pole;
            WspolrzedneSrodka = wspolrzedne;
            Etykieta = etykieta;
        }
    }
}
