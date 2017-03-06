using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Spiel
    {
        #region Übergabe
        private List<Koordinate> koordinaten = new List<Koordinate>();
        private List<Koordinate> foodxy = new List<Koordinate>();
        private PictureBox pb;
        private Brush schlange = Zufall.Brush_Generator();
        private int breite, boxanzahl, richtung, i = 0;
        private bool dead, rand, striche, hungrig;
        #endregion
        #region Einstellungen
        public bool Bunt { get; set; }
        public Color Background { get; set; }
        public Brush Schatten { get; set; }
        #endregion

        public Spiel(PictureBox Picture, int Breite, int Boxanzahl, bool Rand)
        {
            //Nur am Anfang festlegen
            pb = Picture;
            breite = Breite;
            boxanzahl = Boxanzahl;
            rand = Rand;
            hungrig = true; //Bei false gibt es keine Items
            richtung = 3; //Rechts als Anfangsrichtung

            //Während dem Spiel festlegbar
            Background = Color.White;
            Schatten = Brushes.White;
            Bunt = false;

            //Gitter wird von der Breite und Höhe angepasst und mit Farbe gefüllt
            Gitter.Gitter_Anpassen(pb, breite, boxanzahl);
            Gitter.Gitter_Loeschen(pb, Background);

            koordinaten.Add(new Koordinate(0, 0, Brushes.Red));
        }

        public void Check()
        {
            #region Snake überprüfen
            for (int i = 1; i < koordinaten.Count(); i++)
            {
                if (koordinaten[0].KoordinateX == koordinaten[i].KoordinateX && koordinaten[0].KoordinateY == koordinaten[i].KoordinateY)
                    dead = true;
            }
            #endregion
            #region Mit Rand
            if (rand == true)
            {
                //Boxanzahl ist 1 höher,
                if (koordinaten[0].KoordinateX > boxanzahl - 1)
                    koordinaten[0].KoordinateX = 0;
                else if (koordinaten[0].KoordinateX < 0)
                    koordinaten[0].KoordinateX = boxanzahl - 1;
                else if (koordinaten[0].KoordinateY > boxanzahl - 1)
                    koordinaten[0].KoordinateY = 0;
                else if (koordinaten[0].KoordinateY < 0)
                    koordinaten[0].KoordinateY = boxanzahl - 1;
            }
            #endregion
            #region Ohne Rand
            else if (koordinaten[0].KoordinateX < 0 || koordinaten[0].KoordinateX == boxanzahl ||
                     koordinaten[0].KoordinateY < 0 || koordinaten[0].KoordinateY == boxanzahl)
                dead = true;
            #endregion
        }

        public void Move(int Richtung)
        {
            if (dead == false)
            {
                #region Listenänderung K[Index > 0]
                //Erst den damit Listeneintrag 0/0 berücksichtigt wird!
                //Letzer Eintrag wird übermalt
                Gitter.Gitter_Fuellen(pb, Schatten, breite, koordinaten[koordinaten.Count() - 1].KoordinateY, koordinaten[koordinaten.Count() - 1].KoordinateX);
                for (int i = koordinaten.Count() - 1; i > 0; i--) //Bis Kopf erreicht wird
                {
                    koordinaten[i].KoordinateX = koordinaten[i - 1].KoordinateX;
                    koordinaten[i].KoordinateY = koordinaten[i - 1].KoordinateY;
                }
                #endregion
                #region Steuerung K[0]
                // Richtung ist neue Richtung, richtung ist alte Richtung
                if (Richtung == 1 && richtung != 2) //Oben
                {
                    koordinaten[0].KoordinateY--;
                    richtung = Richtung;
                }
                else if (Richtung == 2 && richtung != 1) //Unten
                {
                    koordinaten[0].KoordinateY++;
                    richtung = Richtung;
                }
                else if (Richtung == 3 && richtung != 4) //Rechts 
                {
                    koordinaten[0].KoordinateX++;
                    richtung = Richtung;
                }
                else if (Richtung == 4 && richtung != 3) //Links 
                {
                    koordinaten[0].KoordinateX--;
                    richtung = Richtung;
                }
                else
                {
                    if (richtung == 1)
                        koordinaten[0].KoordinateY--;
                    if (richtung == 2)
                        koordinaten[0].KoordinateY++;
                    if (richtung == 3)
                        koordinaten[0].KoordinateX++;
                    if (richtung == 4)
                        koordinaten[0].KoordinateX--;
                }
                #endregion
            }
        }

        public void Striche()
        {
            if (striche == false)
            {
                striche = true;
                Gitter.Gitter_Zeichnen(pb, Pens.Black, Background, breite);
            }
            else
            {
                striche = false;
                Gitter.Gitter_Loeschen(pb, Background);
            }

            //Zum Anpassen
            Aktualisieren();
            Food();
        }

        public void Aktualisieren()
        {
            if (dead == false)
            {
                foreach (Koordinate element in koordinaten)
                    Gitter.Gitter_Fuellen(pb, element.FarbeXY, breite, element.KoordinateY, element.KoordinateX);
            }
        }

        public int Food()
        {
            try
            {
                if (dead == false)
                {
                    if (hungrig)
                    {
                        foodxy.Add(new Koordinate(Zufall.int_Generator(0, boxanzahl - 1), Zufall.int_Generator(0, boxanzahl - 1)));
                        Gitter.Gitter_Fuellen(pb, Brushes.Black, breite, foodxy[i].KoordinateY, foodxy[i].KoordinateX);
                        hungrig = false;
                    }
                    else if (koordinaten[0].KoordinateX == foodxy[i].KoordinateX && koordinaten[0].KoordinateY == foodxy[i].KoordinateY)
                    {
                        i = foodxy.Count();
                        hungrig = true;
                        koordinaten.Add(new Koordinate(boxanzahl, boxanzahl));
                    }
                    else
                        Gitter.Gitter_Fuellen(pb, Brushes.Black, breite, foodxy[i].KoordinateY, foodxy[i].KoordinateX);
                }
                return foodxy.Count();
            }
            catch
            {
                return 0;
                //Hungrig = false, also keine Items
            }
        }
    }
}
