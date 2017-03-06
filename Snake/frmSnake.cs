using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class frmSnake : Form
    {
        int Richtung;
        bool Stoppen;
        Spiel Spiel1; //Hier muss ich weiter machen

        public frmSnake()
        {
            InitializeComponent();
        }

        private void timTick_Tick(object sender, EventArgs e)
        {
            Spiel1.Move(Richtung);
            Spiel1.Check();
            scoreToolStripMenuItem.Text = "Score: " + Spiel1.Food().ToString();
            Spiel1.Aktualisieren();

        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Richtung = 4;
                    break;
                case Keys.Down:
                    Richtung = 2;
                    break;
                case Keys.Right:
                    Richtung = 3;
                    break;
                case Keys.Up:
                    Richtung = 1;
                    break;
                default:
                    break;
            }
        }

        private void StripStarten_Click(object sender, EventArgs e)
        {
            Spiel1 = new Spiel(pbMalen, 25, 20, true); //Einige Einstellungen
            timTick.Enabled = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void StripGitter_einzeichnen_Click(object sender, EventArgs e)
        {
            Spiel1.Striche();
        }

        private void stoppenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Stoppen == false)
            {
                timTick.Enabled = false;
                Stoppen = true;
            }
            else
            {
                timTick.Enabled = true;
                Stoppen = false;
            }


        }
    }
}