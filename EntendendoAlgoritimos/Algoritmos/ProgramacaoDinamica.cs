using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Algoritmos
{
    public class ProgramacaoDinamica
    {
        public static int[,] Dinamica(String palavraA, String palavraB)
        {


            int[,] cell = new int[palavraA.Length, palavraB.Length];

            for (int i = 0; i < palavraA.Length; i++)
            {
                for (int j = 0; j < palavraB.Length; j++)
                {
                    // The letters match
                    if (palavraA[i] == palavraB[j])
                    {
                        if (i > 0 && j > 0)
                        {
                            cell[i, j] = cell[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            cell[i, j] = 1;
                        }
                    }
                    else
                    {
                        // The letters don't match.
                        if (i == 0 && j > 0)
                        {
                            cell[i, j] = cell[i, j - 1];
                        }
                        else if (i > 0 && j == 0)
                        {
                            cell[i, j] = cell[i - 1, j];
                        }
                        else if (i > 0 && j > 0)
                        {
                            cell[i, j] = Math.Max(cell[i - 1, j], cell[i, j - 1]);
                        }
                        else
                        {
                            cell[i, j] = 0;
                        }
                    }
                }
            }
            return cell;
        }
    }
}
