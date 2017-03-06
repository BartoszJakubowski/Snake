using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public static class Gitter
    {
        public static void Gitter_Zeichnen(PictureBox _pb, Pen Striche, Color Background, int Breite)
        {
            Graphics _gr = _pb.CreateGraphics();
            int x, y;

            _gr.Clear(Background);
            x = 0;

           for (y = 0; y < (_pb.Height); y += Breite)
               _gr.DrawLine(Striche, x, y, _pb.Width, y);

            y = 0;

           for (x = 0; x < (_pb.Width); x += Breite)
               _gr.DrawLine(Striche, x, y, x, _pb.Height);
        }
        public static void Gitter_Anpassen(PictureBox _pb, int Breite, int Boxanzahl)
        {
            Graphics _gr = _pb.CreateGraphics();

            if (Breite > 4 && Boxanzahl > 4 && Breite * Boxanzahl <= _pb.Width)
                _pb.Width = Breite * Boxanzahl;
            if (Breite > 4 && Boxanzahl > 4 && Breite * Boxanzahl <= _pb.Height)
                _pb.Height = Breite * Boxanzahl;
            else
                return;
        }
        public static void Gitter_Fuellen(PictureBox _pb, Brush Inhalt, int Breite, int KastenY, int KastenX) {
            Graphics _gr = _pb.CreateGraphics();
            int x, y;

            x = Breite * KastenX;
            y = Breite * KastenY;
            _gr.FillRectangle(Inhalt, x + 1, y + 1, Breite - 1, Breite - 1);
        }
        public static void Gitter_Loeschen(PictureBox _pb, Color Background)
        {
            Graphics _gr = _pb.CreateGraphics();

            _gr.Clear(Background);
        }
    }
}