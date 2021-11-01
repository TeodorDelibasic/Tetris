using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Tetris
{
    public partial class Tetris : Form
    {
        public Tetris()
        {
            InitializeComponent();
            DoubleBuffered = true;
            KeyPreview = true;
        }

        #region Rotacija (Metode za rotaciju svih figura.)

        public void RotacijaI(List<Blok> f, Blok[][] b, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        if (f[0].Red < 2 || f[3].Red > 18) break;
                        if (!(b[f[0].Red - 2][f[0].Kolona + 1] == null && b[f[1].Red - 1][f[1].Kolona] == null && b[f[3].Red + 1][f[3].Kolona - 2] == null)) break;
                        else
                        {
                            f[0].o.X += 35;                       
                            f[0].o.Y -= 70;
                            f[0].Kolona += 1;                          
                            f[0].Red -= 2;

                            f[1].o.Y -= 35;
                            f[1].Red -= 1;

                            f[2].o.X -= 35;
                            f[2].Kolona -= 1;

                            f[3].o.X -= 70;
                            f[3].o.Y += 35;
                            f[3].Kolona -= 2;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
                case 1:
                    {
                        if (f[0].Kolona > 7 || f[3].Kolona < 1) break;
                        if (!(b[f[0].Red + 2][f[0].Kolona + 2] == null && b[f[1].Red + 1][f[1].Kolona + 1] == null && b[f[3].Red - 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.X += 70;
                            f[0].o.Y += 70;
                            f[0].Kolona += 2;
                            f[0].Red += 2;

                            f[1].o.X += 35;
                            f[1].o.Y += 35;
                            f[1].Kolona += 1;
                            f[1].Red += 1;

                            f[3].o.X -= 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona -= 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 2:
                    {
                        if (f[3].Red < 2 || f[0].Red > 18) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona - 1] == null && b[f[2].Red - 1][f[2].Kolona + 1] == null && b[f[3].Red - 2][f[3].Kolona + 2] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y += 35;
                            f[0].Kolona -= 1;
                            f[0].Red += 1;

                            f[2].o.X += 35;
                            f[2].o.Y -= 35;
                            f[2].Kolona += 1;
                            f[2].Red -= 1;

                            f[3].o.X += 70;
                            f[3].o.Y -= 70;
                            f[3].Kolona += 2;
                            f[3].Red -= 2;

                            m++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (f[0].Kolona < 2 || f[3].Kolona > 8) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona - 2] == null && b[f[1].Red][f[1].Kolona - 1] == null && b[f[3].Red + 2][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.X -= 70;
                            f[0].o.Y -= 35;
                            f[0].Kolona -= 2;
                            f[0].Red -= 1;

                            f[1].o.X -= 35;
                            f[1].Kolona -= 1;

                            f[2].o.Y += 35;
                            f[2].Red += 1;

                            f[3].o.X += 35;
                            f[3].o.Y += 70;
                            f[3].Kolona += 1;
                            f[3].Red += 2;

                            m++;
                        }
                        break;
                    }
            }
        }

        public void RotacijaJ(List<Blok> f, Blok[][] b, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        if (f[0].Red < 1) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona + 1] == null && b[f[2].Red + 1][f[2].Kolona] == null && b[f[3].Red][f[3].Kolona - 2] == null)) break;
                        else
                        {
                            f[0].o.X += 35;
                            f[0].o.Y -= 35;
                            f[0].Kolona += 1;
                            f[0].Red -= 1;

                            f[2].o.X -= 35;
                            f[2].o.Y += 35;
                            f[2].Red += 1;
                            f[2].Kolona -= 1;

                            f[3].o.X -= 70;
                            f[3].Kolona -= 2;

                            m++;
                        }
                        break;
                    }
                case 1:
                    {
                        if (f[0].Kolona > 8) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona + 1] == null && b[f[2].Red - 1][f[2].Kolona - 1] == null && b[f[3].Red - 2][f[3].Kolona] == null)) break;
                        else
                        {
                            f[0].o.X += 35;
                            f[0].o.Y += 35;
                            f[0].Kolona += 1;
                            f[0].Red += 1;

                            f[2].o.X -= 35;
                            f[2].o.Y -= 35;
                            f[2].Kolona -= 1;
                            f[2].Red -= 1;

                            f[3].o.Y -= 70;
                            f[3].Red -= 2;

                            m++;
                        }
                        break;
                    }
                case 2:
                    {
                        if (f[0].Red > 18) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona - 1] == null && b[f[2].Red - 1][f[2].Kolona + 1] == null && b[f[3].Red][f[3].Kolona + 2] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y += 35;
                            f[0].Kolona -= 1;
                            f[0].Red += 1;

                            f[2].o.X += 35;
                            f[2].o.Y -= 35;
                            f[2].Kolona += 1;
                            f[2].Red -= 1;

                            f[3].o.X += 70;
                            f[3].Kolona += 2;

                            m++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (f[0].Kolona < 1) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona - 1] == null && b[f[2].Red + 1][f[2].Kolona + 1] == null && b[f[3].Red + 2][f[3].Kolona] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y -= 35;
                            f[0].Kolona -= 1;
                            f[0].Red -= 1;

                            f[2].o.X += 35;
                            f[2].o.Y += 35;
                            f[2].Kolona += 1;
                            f[2].Red += 1;

                            f[3].o.Y += 70;
                            f[3].Red += 2;

                            m++;
                        }
                        break;
                    }
            }
        }

        public void RotacijaL(List<Blok> f, Blok[][] b, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        if (f[0].Red < 2) break;
                        if (!(b[f[0].Red - 2][f[0].Kolona] == null && b[f[1].Red - 1][f[1].Kolona + 1] == null && b[f[3].Red + 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.Y -= 70;
                            f[0].Red -= 2;

                            f[1].o.X += 35;
                            f[1].o.Y -= 35;
                            f[1].Kolona += 1;
                            f[1].Red -= 1;

                            f[3].o.X -= 35;
                            f[3].o.Y += 35;
                            f[3].Kolona -= 1;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
                case 1:
                    {
                        if (f[0].Kolona > 8) break;
                        if (!(b[f[0].Red][f[0].Kolona + 2] == null && b[f[1].Red + 1][f[1].Kolona + 1] == null && b[f[3].Red - 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.X += 70;
                            f[0].Kolona += 2;

                            f[1].o.X += 35;
                            f[1].o.Y += 35;
                            f[1].Kolona += 1;
                            f[1].Red += 1;

                            f[3].o.X -= 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona -= 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 2:
                    {
                        if (f[0].Red > 18) break;
                        if (!(b[f[0].Red + 2][f[0].Kolona] == null && b[f[1].Red + 1][f[1].Kolona - 1] == null && b[f[3].Red - 1][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.Y += 70;
                            f[0].Red += 2;

                            f[1].o.X -= 35;
                            f[1].o.Y += 35;
                            f[1].Kolona -= 1;
                            f[1].Red += 1;

                            f[3].o.X += 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona += 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (f[0].Kolona < 1) break;
                        if (!(b[f[0].Red][f[0].Kolona - 2] == null && b[f[1].Red - 1][f[1].Kolona - 1] == null && b[f[3].Red + 1][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.X -= 70;
                            f[0].Kolona -= 2;

                            f[1].o.X -= 35;
                            f[1].o.Y -= 35;
                            f[1].Red -= 1;
                            f[1].Kolona -= 1;

                            f[3].o.X += 35;
                            f[3].o.Y += 35;
                            f[3].Kolona += 1;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
            }
        }

        public void RotacijaS(List<Blok> f, Blok[][] b, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        if (f[3].Red > 18) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona + 1] == null && b[f[2].Red + 1][f[2].Kolona + 1] == null && b[f[3].Red + 2][f[3].Kolona] == null)) break;
                        else
                        {
                            f[0].o.Y -= 35;
                            f[0].o.X += 35;
                            f[0].Red -= 1;
                            f[0].Kolona += 1;

                            f[2].o.X += 35;
                            f[2].o.Y += 35;
                            f[2].Kolona += 1;
                            f[2].Red += 1;

                            f[3].o.Y += 70;
                            f[3].Red += 2;

                            m++;
                        }
                        break;
                    }
                case 1:
                    {
                        if (f[3].Kolona < 1) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona + 1] == null && b[f[2].Red + 1][f[2].Kolona - 1] == null && b[f[3].Red][f[3].Kolona - 2] == null)) break;
                        else
                        {
                            f[0].o.X += 35;
                            f[0].o.Y += 35;
                            f[0].Kolona += 1;
                            f[0].Red += 1;

                            f[2].o.X -= 35;
                            f[2].o.Y += 35;
                            f[2].Kolona -= 1;
                            f[2].Red += 1;

                            f[3].o.X -= 70;
                            f[3].Kolona -= 2;

                            m++;
                        }
                        break;
                    }
                case 2:
                    {
                        if (f[3].Red < 1) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona - 1] == null && b[f[2].Red - 1][f[2].Kolona - 1] == null && b[f[3].Red - 2][f[3].Kolona] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y += 35;
                            f[0].Red += 1;
                            f[0].Kolona -= 1;

                            f[2].o.X -= 35;
                            f[2].o.Y -= 35;
                            f[2].Kolona -= 1;
                            f[2].Red -= 1;

                            f[3].o.Y -= 70;
                            f[3].Red -= 2;

                            m++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (f[3].Kolona > 8) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona - 1] == null && b[f[2].Red - 1][f[2].Kolona + 1] == null && b[f[3].Red][f[3].Kolona + 2] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y -= 35;
                            f[0].Red -= 1;
                            f[0].Kolona -= 1;

                            f[2].o.X += 35;
                            f[2].o.Y -= 35;
                            f[2].Red -= 1;
                            f[2].Kolona += 1;

                            f[3].o.X += 70;
                            f[3].Kolona += 2;

                            m++;
                        }
                        break;
                    }
            }
        }

        public void RotacijaZ(List<Blok> f, Blok[][] b, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        if (f[3].Red > 18) break;
                        if (!(b[f[0].Red][f[0].Kolona + 2] == null && b[f[1].Red + 1][f[1].Kolona + 1] == null && b[f[3].Red + 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.X += 70;
                            f[0].Kolona += 2;

                            f[1].o.X += 35;
                            f[1].o.Y += 35;
                            f[1].Red += 1;
                            f[1].Kolona += 1;

                            f[3].o.X -= 35;
                            f[3].o.Y += 35;
                            f[3].Kolona -= 1;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
                case 1:
                    {
                        if (f[3].Kolona < 1) break;
                        if (!(b[f[0].Red + 2][f[0].Kolona] == null && b[f[1].Red + 1][f[1].Kolona - 1] == null && b[f[3].Red - 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.Y += 70;
                            f[0].Red += 2;

                            f[1].o.X -= 35;
                            f[1].o.Y += 35;
                            f[1].Kolona -= 1;
                            f[1].Red += 1;

                            f[3].o.X -= 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona -= 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 2:
                    {
                        if (f[3].Red < 1) break;
                        if (!(b[f[0].Red][f[0].Kolona - 2] == null && b[f[1].Red - 1][f[1].Kolona - 1] == null && b[f[3].Red - 1][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.X -= 70;
                            f[0].Kolona -= 2;

                            f[1].o.X -= 35;
                            f[1].o.Y -= 35;
                            f[1].Kolona -= 1;
                            f[1].Red -= 1;

                            f[3].o.X += 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona += 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (f[3].Kolona > 8) break;
                        if (!(b[f[0].Red - 2][f[0].Kolona] == null && b[f[1].Red - 1][f[1].Kolona + 1] == null && b[f[3].Red + 1][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.Y -= 70;
                            f[0].Red -= 2;

                            f[1].o.X += 35;
                            f[1].o.Y -= 35;
                            f[1].Kolona += 1;
                            f[1].Red -= 1;

                            f[3].o.X += 35;
                            f[3].o.Y += 35;
                            f[3].Kolona += 1;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
            }
        }

        public void RotacijaT(List<Blok> f, Blok[][] b, int k)
        {
            switch (k)
            {
                case 0:
                    {
                        if (f[0].Red < 1) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona + 1] == null && b[f[2].Red + 1][f[2].Kolona - 1] == null && b[f[3].Red - 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.X += 35;
                            f[0].o.Y -= 35;
                            f[0].Red -= 1;
                            f[0].Kolona += 1;

                            f[2].o.X -= 35;
                            f[2].o.Y += 35;
                            f[2].Red += 1;
                            f[2].Kolona -= 1;

                            f[3].o.X -= 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona -= 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 1:
                    {
                        if (f[0].Kolona > 8) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona + 1] == null && b[f[2].Red - 1][f[2].Kolona - 1] == null && b[f[3].Red - 1][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.X += 35;
                            f[0].o.Y += 35;
                            f[0].Red += 1;
                            f[0].Kolona += 1;

                            f[2].o.X -= 35;
                            f[2].o.Y -= 35;
                            f[2].Kolona -= 1;
                            f[2].Red -= 1;

                            f[3].o.X += 35;
                            f[3].o.Y -= 35;
                            f[3].Kolona += 1;
                            f[3].Red -= 1;

                            m++;
                        }
                        break;
                    }
                case 2:
                    {
                        if (f[0].Red >81) break;
                        if (!(b[f[0].Red + 1][f[0].Kolona - 1] == null && b[f[2].Red - 1][f[2].Kolona + 1] == null && b[f[3].Red + 1][f[3].Kolona + 1] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y += 35;
                            f[0].Red += 1;
                            f[0].Kolona -= 1;

                            f[2].o.X += 35;
                            f[2].o.Y -= 35;
                            f[2].Kolona += 1;
                            f[2].Red -= 1;

                            f[3].o.X += 35;
                            f[3].o.Y += 35;
                            f[3].Kolona += 1;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (f[3].Kolona < 1) break;
                        if (!(b[f[0].Red - 1][f[0].Kolona - 1] == null && b[f[2].Red + 1][f[2].Kolona + 1] == null && b[f[3].Red + 1][f[3].Kolona - 1] == null)) break;
                        else
                        {
                            f[0].o.X -= 35;
                            f[0].o.Y -= 35;
                            f[0].Red -= 1;
                            f[0].Kolona -= 1;

                            f[2].o.X += 35;
                            f[2].o.Y += 35;
                            f[2].Kolona += 1;
                            f[2].Red += 1;

                            f[3].o.X -= 35;
                            f[3].o.Y += 35;
                            f[3].Kolona -= 1;
                            f[3].Red += 1;

                            m++;
                        }
                        break;
                    }
            }
        }

        #endregion

        #region Promenljive
        List<string[]> rez = new List<string[]>(6);

        StreamReader sr = new StreamReader("Rezultati.txt");

        Random R = new Random();

        int n, m = 0;
        int k;
        int rezultat = 0;
        List<int> ts = new List<int>();

        PointF O = new PointF((float)157.5, (float)17.5);
        PointF C = new PointF((float)52.5, (float)52.5);

        Boolean t = true;
        Boolean p;
        Boolean r;

        List<Blok> b = new List<Blok>(4);
        List<Blok> s = new List<Blok>(4);

        Mreza mreza = new Mreza();
        #endregion

        public void NapraviBlok()
        {
            Color boja;

            switch (k)
            {
                
                case 0:
                case 1:
                    boja = Color.Red; 
                    n = 0;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y), 0, 3));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y), 0, 5));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y + 35), 1, 5));
                    break;

                case 2:
                case 3:
                    boja = Color.Blue;
                    n = 1;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y + 35), 1, 3));
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y), 0, 3));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y), 0, 5));                   
                    break;

                case 4:
                case 5:
                    boja = Color.Yellow;
                    n = 2;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y + 35), 1, 3));
                    b.Add(new Blok(boja, new PointF(O.X, O.Y + 35), 1, 4));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y), 0, 5));
                    break;

                case 6:
                case 7:
                    boja = Color.Orange;
                    n = 3;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y), 0, 3));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X, O.Y + 35), 1, 4));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y + 35), 1, 5));
                    break;

                case 8:
                case 9:
                    n = 5;
                    boja = Color.Magenta;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y), 0, 3));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y + 35), 1, 3));
                    b.Add(new Blok(boja, new PointF(O.X, O.Y + 35), 1, 4));
                    break;

                case 10:
                case 11:
                    boja = Color.Cyan;
                    n = 4;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y), 0, 3));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y), 0, 5));
                    b.Add(new Blok(boja, new PointF(O.X, O.Y + 35), 1, 4));
                    break;

                case 12:
                case 13:
                    boja = Color.Green;
                    n = 6;
                    b.Add(new Blok(boja, new PointF(O.X - 35, O.Y), 0, 3));
                    b.Add(new Blok(boja, O, 0, 4));
                    b.Add(new Blok(boja, new PointF(O.X + 35, O.Y), 0, 5));
                    b.Add(new Blok(boja, new PointF(O.X + 70, O.Y), 0, 6));
                    break;
                   

                default:
                    break;
            }
        } //Pravi figuru.

        public void NapraviSledeci()
        {
            Color boja;

            switch (k)
            {

                case 0:
                case 1:
                    boja = Color.Red;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y), 0, 3));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y), 0, 5));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y + 35), 1, 5));
                    break;

                case 2:
                case 3:
                    boja = Color.Blue;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y + 35), 1, 3));
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y), 0, 3));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y), 0, 5));
                    break;

                case 4:
                case 5:
                    boja = Color.Yellow;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y + 35), 1, 3));
                    s.Add(new Blok(boja, new PointF(C.X, C.Y + 35), 1, 4));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y), 0, 5));
                    break;

                case 6:
                case 7:
                    boja = Color.Orange;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y), 0, 3));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X, C.Y + 35), 1, 4));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y + 35), 1, 5));
                    break;

                case 8:
                case 9:
                    boja = Color.Magenta;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y), 0, 3));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y + 35), 1, 3));
                    s.Add(new Blok(boja, new PointF(C.X, C.Y + 35), 1, 4));
                    break;

                case 10:
                case 11:
                    boja = Color.Cyan;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y), 0, 3));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y), 0, 5));
                    s.Add(new Blok(boja, new PointF(C.X, C.Y + 35), 1, 4));
                    break;

                case 12:
                case 13:
                    boja = Color.Green;
                    s.Add(new Blok(boja, new PointF(C.X - 35, C.Y), 0, 3));
                    s.Add(new Blok(boja, C, 0, 4));
                    s.Add(new Blok(boja, new PointF(C.X + 35, C.Y), 0, 5));
                    s.Add(new Blok(boja, new PointF(C.X + 70, C.Y), 0, 6));
                    break;


                default:
                    break;
            }
        }  //Pravi sledecu figuru.

        private void Tetris_Box_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Gray, 1);

            float y1 = Tetris_Box.Height;
            float y2 = 0;
            for (float i = 35; i < 350; i += 35)
            {
                g.DrawLine(p, i, y1, i, y2);
            }

            float x1 = 0;
            float x2 = Tetris_Box.Width;
            for (float i = 35; i < 700; i += 35)
            {
                g.DrawLine(p, x1, i, x2, i);
            }

            g.DrawLine(p, x1, y2, x1, y1);
            g.DrawLine(p, x1, y2, x2, y2);
            g.DrawLine(p, x2 - 1, y1, x2 - 1, y2);
            g.DrawLine(p, x2 - 1, y1 - 1, x1, y1 - 1);

            foreach (Blok n in b) n.CrtajBlok(g);

            for (int i = 0; i < mreza.B.Length; i++)
            {
                for (int j = 0; j < mreza.B[i].Length; j++)
                {
                    if (mreza.B[i][j] != null) mreza.B[i][j].CrtajBlok(g);
                }
            }
        }

        private void Spustanje_Tick(object sender, EventArgs e)
        {
            p = true;

            if (t) // Proverava da li treba da se napravi sledecu figuru.
            {
                m = 0;
                NapraviBlok();
                k = R.Next(14);
                s.Clear();
                NapraviSledeci();
                t = false;
            }

            else
            {
                foreach (Blok n in b)
                {
                    if (n.Red < 19)
                    {
                        if (!(n.Spustanjepom(Tetris_Box.Height, mreza.B[n.Red + 1][n.Kolona])))
                        {
                            p = false;
                        }
                    }

                    else p = false;
                }

                if (p)
                {
                    foreach (Blok n in b)
                    {
                        n.Spustanje();
                    }
                }

                else
                {
                    t = true;

                    foreach (Blok n in b) // Dodaje u mrezu blokove koji su se zaustavili.
                    {
                        n.V = 0;
                        mreza.B[n.Red][n.Kolona] = n;
                    }

                    if (mreza.KrajIgre())
                    {  
                        Spustanje.Stop();
                        Rezultat.Stop();

                        Rezultati.Items.Clear();
                        Rezultati.Items.Add("Rezultati:");
                        StreamWriter sw = new StreamWriter("Rezultati.txt");
                        sw.WriteLine("Rezultati:");
                        for (int i = 1; i < rez.Count; i++)
                        {
                            if (int.Parse(rez[i][2]) < rezultat)
                            {                 
                                for (int j = i + 1; j < rez.Count; j++)
                                {
                                    rez[j][1] = rez[j - 1][1];
                                    rez[j][2] = rez[j - 1][2];
                                }
                                rez[i][1] = Ime.Text;
                                rez[i][2] = rezultat.ToString();
                                break;
                            }
                        }
                        for (int i = 1; i < rez.Count; i++)
                        {
                            sw.WriteLine(rez[i][0] + " " + rez[i][1] + " " + rez[i][2]);
                            Rezultati.Items.Add(rez[i][0] + " " + rez[i][1] + " " + rez[i][2]);
                        }
                        sw.Close();

                        MessageBox.Show("Kraj igre.");
                    }

                    mreza.Brisanje(ref rezultat);
                    PrikazRezultata.Text = rezultat.ToString();
                    b.Clear();
                }
            }
            Refresh();
        }

        private void Tetris_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Escape)
            {
                Spustanje.Stop();
                MessageBox.Show("Pauza");
            }

            r = true;

            if (e.KeyChar == 'a') // Pomeranje levo.
            {
                foreach (Blok n in b)
                {
                    if (n.Kolona > 0)
                    {
                        if (!(n.Pomeranje1pom(mreza.B[n.Red][n.Kolona - 1])))
                        {
                            r = false;
                        }
                    }

                    else r = false;
                }

                if (r)
                {

                    foreach (Blok n in b)
                    {

                        n.Pomeranje1();
                    }
                }
            }

            if (e.KeyChar == 'd') // Pomeranje desno.
            {
                foreach (Blok n in b)
                {
                    if (n.Kolona < 9)
                    {
                        if (!(n.Pomeranje2pom(mreza.B[n.Red][n.Kolona + 1], Tetris_Box.Width)))
                        {
                            r = false;
                        }
                    }

                    else r = false;
                }

                if (r)
                {
                    foreach (Blok n in b)
                    {
                        n.Pomeranje2();
                    }
                }
            }

            if (e.KeyChar == 's') // Padanje do najdalje moguce pozicije.
            {
                Spustanje.Stop();

                Blok k;
                int min;

                k = null;
                min = 20;

                for (int i = 0; i < 4; i++)
                {
                    if (b[i].Padanjepom(mreza.B) < min)
                    {
                        min = b[i].Padanjepom(mreza.B);
                        k = b[i];
                    }
                }

                foreach (Blok n in b)
                {
                    n.Padanje(min - 1);
                    n.V = 0;
                    mreza.B[n.Red][n.Kolona] = n;
                }

                rezultat += min;

                b.Clear();

                mreza.Brisanje(ref rezultat);

                t = true;

                Spustanje.Start();
            }

            if (e.KeyChar == 'w') // Rotacija.
            {
                if (m == 4) m = 0;

                switch (n)
                {
                    case 0:
                        {
                            RotacijaJ(b, mreza.B, m);
                            break;
                        }
                    case 1:
                        {
                            RotacijaL(b, mreza.B, m);
                            break;
                        }
                    case 2:
                        {
                            RotacijaS(b, mreza.B, m);
                            break;
                        }
                    case 3:
                        {
                            RotacijaZ(b, mreza.B, m);
                            break;
                        }
                    case 4:
                        {
                            RotacijaT(b, mreza.B, m);
                            break;
                        }
                    case 5:
                        break;
                    case 6:
                        {
                            RotacijaI(b, mreza.B, m);
                            break;
                        }
                }

            }
            Refresh();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Spustanje.Start();
            Rezultat.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Spustanje.Stop();
            Rezultat.Stop();
        }

        private void Next_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Gray, 1);

            float y1 = Next.Height;
            float y2 = 0;
            for (float i = 35; i < 140; i += 35)
            {
                g.DrawLine(p, i, y1, i, y2);
            }

            float x1 = 0;
            float x2 = Next.Width;
            for (float i = 35; i < 140; i += 35)
            {
                g.DrawLine(p, x1, i, x2, i);
            }

            g.DrawLine(p, x1, y2, x1, y1);
            g.DrawLine(p, x1, y2, x2, y2);
            g.DrawLine(p, x2 - 1, y1, x2 - 1, y2);
            g.DrawLine(p, x2 - 1, y1 - 1, x1, y1 - 1);

            foreach (Blok n in s)
            {
                n.CrtajBlok(g);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (!sr.EndOfStream)
            {
                string s1 = sr.ReadLine();
                string[] s2 = s1.Split(' ');
                Rezultati.Items.Add(s1);
                rez.Add(s2);
            }
            sr.Close();

            Size = new Size(850, 770);
            BackColor = Color.FromArgb(128, 255, 128);
            ForeColor = Color.Black;

            Tetris_Box.Location = new Point(175, 10);
            Tetris_Box.Size = new Size(350, 700);

            Next.Location = new Point(531, 10);
            Next.Size = new Size(140, 140);

            Start.Size = new Size(150, 50);
            Start.Location = new Point(12, 10);

            Stop.Size = new Size(150, 50);
            Stop.Location = new Point(12, 66);

            Restart.Size = new Size(150, 50);
            Restart.Location = new Point(12, 122);

            PrikazRezultata.Text = rezultat.ToString();
            PrikazRezultata.Location = new Point(530, 220);

            label1.Text = "Rezultat";
            label1.Location = new Point(530, 180);

            Rezultati.Size = new Size(290, 125);
            Rezultati.Location = new Point(530, 375);

            label4.Location = new Point(12, 175);

            Ime.Location = new Point(12, 200);
            Ime.Size = new Size(120, 22);

            k = R.Next(14);
            NapraviSledeci();

            PodesavanjeBrzine.Value = 450;

            MessageBox.Show("Unesite ime!");
        }

        private void Rezultat_Tick(object sender, EventArgs e)
        {
            rezultat++;
            PrikazRezultata.Text = rezultat.ToString();
        }

        private void PodesavanjeBrzine_ValueChanged(object sender, EventArgs e)
        {
            Spustanje.Interval = 900 - PodesavanjeBrzine.Value;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Spustanje.Stop();
            Rezultat.Stop();
            PrikazRezultata.Text = "0";

            b.Clear();
            t = true;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mreza.B[i][j] = null;
                }
            }

            Refresh();
        }
    }
}
