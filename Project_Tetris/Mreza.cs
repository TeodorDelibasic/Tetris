using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tetris
{
    public class Mreza
    {
        public Blok[][] B = new Blok[20][];

        public Mreza()
        {
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = new Blok[10];
                for (int j = 0; j < B[i].Length; j++)
                {
                    B[i][j] = null;
                }
            }
        }

        public void Brisanje(ref int n) // Brise popunjene redove. (n je rezultat, koji se povecava za 10 za svaki obrisani red.)
        {
            Boolean w = true;

            for (int i = 19; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (B[i][j] == null) w = false;
                }

                if (w)
                {
                    n += 10;
                    for (int j = 0; j < 10; j++)
                    {
                        B[i][j] = null;
                    }
                    for (int k = i; k > 0; k--)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            B[k][j] = B[k - 1][j];
                            if (B[k][j] != null)
                            {
                                B[k][j].o.Y += 35;
                            }
                        }
                    }
                    i++;
                }
                w = true;
            }
        }

        public bool KrajIgre()
        {
            for (int i = 0; i < 10; i++)
            {
                if (B[0][i] != null) return true;
            }
            return false;
        } // Proverava da li je neki blok dosao do vrha.
    }
}
