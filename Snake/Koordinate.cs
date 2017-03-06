using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Snake
{
    class Koordinate
    {
        public int KoordinateX { get; set; }
        public int KoordinateY { get; set; }
        public Brush FarbeXY { get; set; }

        public Koordinate(int X, int Y) //Zufall
        {
            KoordinateX = X;
            KoordinateY = Y;
            FarbeXY = Zufall.Brush_Generator();
        }

        public Koordinate(int X, int Y, Brush Farbe) //Übergeben
        {
            KoordinateX = X;
            KoordinateY = Y;
            FarbeXY = Farbe;
        }
    }
}
