using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project_Tetris
{
    public class Blok
    {
        #region Atributi
        public PointF o;
        Color boja;
        static float r = 35;
        float v = 35;
        int red;
        int kolona;
        #endregion

        #region Konstruktori
        public Blok()
        {
            boja = Color.Black;
            o = new PointF((float)157.5, (float)17.5);
            red = 0;
            kolona = 4;
        }
        public Blok(Color boja, PointF o, int red = 0, int kolona = 4)
        {
            this.boja = boja;
            this.o = o;
            this.kolona = kolona;
            this.red = red;
        }
        #endregion

        #region Svojstva
        public int Red
        {
            get { return red; }
            set { red = value; }
        }
        public int Kolona
        {
            get { return kolona; }
            set { kolona = value; }
        }
        public PointF O
        {
            get { return o; }
            set { o = value; }
        }
        public float V
        {
            get { return v; }
            set { v = value; }
        }
        #endregion

        #region Metode
        public void CrtajBlok(Graphics g)
        {
            SolidBrush s = new SolidBrush(boja);
            g.FillRectangle(s, O.X - r / 2 + 1, O.Y - r / 2 + 1, r - 1, r - 1);
        }

        public int Padanjepom(Blok[][] b)
        {
            int i = red;
            while (i < 20 && b[i][kolona] == null) i++;
            return i - red;
        } // Proverava gde moze blok da padne.
        public void Padanje(int i)
        {
            red += i;
            o.Y += i* 35;
        }

        public bool Spustanjepom(float max, Blok m)
        {
            if (v == 0) return false;
            else
            {
                if (O.Y + v > max) return false;
                else
                {
                    if (m == null) return true;
                    else return false;
                }
            }
        } // Proverava da li blok moze da se spusti.
        public void Spustanje()
        {
            o.Y += v;
            red++;
        }

        public bool Pomeranje1pom(Blok m)
        {
            if (v == 0) return false;
            else
            {
                if (O.X < 35) return false;
                else
                {
                    if (m == null) return true;
                    else return false;
                }
            }
        } // Proverava da li blok moze da se pomeri levo.
        public void Pomeranje1()
        {
            o.X -= v;
            kolona--;
        }

        public bool Pomeranje2pom(Blok m, float max)
        {
            if (v == 0) return false;
            else
            {
                if (O.X + v > max) return false;
                else
                {
                    if (m == null) return true;
                    else return false;
                }
            }
        } // Proverava da li blok moze da se pomeri desno.
        public void Pomeranje2()
        {
            o.X += v;
            kolona++;
        }
        #endregion

    }
}
