using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardanoLattice
{
    class Lattice
    {
        public void Fill(int[,] lattice, int[] size)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    lattice[i, j] = 0;
                }
            }
        }
        public void Print(int[,] lattice, int[] size)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write(lattice[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public void Repair(int[,] lattice, int[] size, string inText, int temp, char[,] matrix)
        {
            int portion = inText.Length / 4;
            char[] phrase = inText.ToCharArray();
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    if (matrix[i, j] == phrase[temp])
                    {
                        lattice[i, j] = 1;
                        temp++;
                        break;
                    }
                }
                if (temp == portion)
                {
                    break;
                }
            }
        }
        public void Right(int[,] lattice, int[] size)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    if (lattice[i, j] == 1)
                    {
                        int a = size[1] - j - 1;
                        lattice[i, a] = 1;
                        if (j != a)
                        {                            
                            lattice[i, j] = 0;
                        }
                        break;
                    }
                }
            }
        }

        public void Down(ref int[,] lattice, int[] size)
        {
            int[,] tempMatrix = new int[size[0],size[1]];
            Fill(tempMatrix, size);           
            for (int j = 0; j < size[1]; j++)
            {
                for (int i = 0; i < size[0]; i++)
                {
                    if (lattice[i,j] == 1)
                    {

                        int a = size[0] - i - 1;
                        tempMatrix[a, j] = 1;
                        
                    }
                }
            } 
            lattice = tempMatrix;
        }

        public void Left(int[,] lattice, int[] size)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    if (lattice[i, j] == 1)
                    {
                        int a = size[1] - j - 1;
                        lattice[i, a] = 1;
                        if (j != a)
                        {
                            lattice[i, j] = 0;
                        }
                        break;
                    }
                }
            }
        }
        
    }
}
