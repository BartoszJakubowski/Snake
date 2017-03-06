using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Zufall
    {
        public static Random rnd = new Random(DateTime.Now.Millisecond);
        //public static Random rndcolor = new Random();

        public static int int_Generator(int Min, int Max)
        {
            int i = rnd.Next(Min, Max + 1);

            return i;
        }
        public static bool bool_Generator()
        {
            int i = rnd.Next(0, 2);

            if (i == 0)
                return false;

            else
                return true;
        }
        public static Brush Brush_Generator()
        {
            //Color rndclr = Color.FromArgb(rndcolor.Next(256), rndcolor.Next(256), rnd.Next(256));
            int i = rnd.Next(1, 9);

            switch (i)
            {
                case 1:
                    return Brushes.Blue;
                case 2:
                    return Brushes.Green;
                case 3:
                    return Brushes.Yellow;
                case 4:
                    return Brushes.Brown;
                case 5:
                    return Brushes.Red;
                case 6:
                    return Brushes.Purple;
                case 7:
                    return Brushes.Magenta;
                case 8:
                    return Brushes.Orange;
                default:
                    return Brushes.Brown;
            }
        }
        public static Color Color_Generator()
        {
            int i = rnd.Next(1, 9);

            switch (i)
            {
                case 1:
                    return Color.Blue;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Yellow;
                case 4:
                    return Color.Brown;
                case 5:
                    return Color.Red;
                case 6:
                    return Color.Purple;
                case 7:
                    return Color.Magenta;
                case 8:
                    return Color.Orange;
                default:
                    return Color.Brown;
            }
        }

        public static Pen Pen_Generator()
        {
            int i = rnd.Next(1, 9);

            switch (i)
            {
                case 1:
                    return Pens.Blue;
                case 2:
                    return Pens.Green;
                case 3:
                    return Pens.Yellow;
                case 4:
                    return Pens.Brown;
                case 5:
                    return Pens.Red;
                case 6:
                    return Pens.Purple;
                case 7:
                    return Pens.Magenta;
                case 8:
                    return Pens.Orange;
                default:
                    return Pens.Brown;
            }
        }
    }
}