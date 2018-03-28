using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardanoLattice
{
    class Matrix
    {
        List<char> alph = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
              'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        Random rnd = new Random();
        public void Fill(char[,] matrix, int[] size)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = alph[rnd.Next(25)];
                }
            }
            
        }

        public void Print(char[,] matrix, int[] size)
        {
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public void Repair(char[,] matrix, int[] size, string inText, int temp)
        {
            int portion = inText.Length / 4;
            char[] phrase = inText.ToCharArray();
            for (int i = 0; i < size[0]; i++)
            {
                if (temp == portion)
                {
                    break;
                }

                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, rnd.Next(size[1])] = phrase[temp];
                    temp++;
                    break;
                }
                


            }
        }

        public void Repair1(int[,] lattice, char[,] matrix, int[] size, int temp, string inText)
        {
            int start = inText.Length / 4;
            int portion = inText.Length / 4 * 2;
            char[] phrase = inText.ToCharArray();
            for (int i = 0; i < size[0]; i++)
            {
                if(start == portion)
                {
                    break;
                }
                for (int j = 0; j < size[1]; j++)
                {
                    if(lattice[i,j] == 1)
                    {
                        matrix[i, j] = phrase[start];
                        start++;
                    }
                }
            }
        }

        public void Repair2(int[,] lattice, char[,] matrix, int[] size, int temp, string inText)
        {
            int start = inText.Length / 4 * 2;
            int portion = inText.Length / 4 * 3;
            char[] phrase = inText.ToCharArray();
            for (int i = 0; i < size[0]; i++)
            {
                if (start == portion)
                {
                    break;
                }
                for (int j = 0; j < size[1]; j++)
                {
                    if (lattice[i, j] == 1)
                    {
                        matrix[i, j] = phrase[start];
                        start++;
                    }
                }
            }
        }

        public void Repair3(int[,] lattice, char[,] matrix, int[] size, int temp, string inText)
        {
            int start = inText.Length / 4 * 3;
            int portion = inText.Length / 4 * 4;
            char[] phrase = inText.ToCharArray();
            for (int i = 0; i < size[0]; i++)
            {
                if (start == portion)
                {
                    break;
                }
                for (int j = 0; j < size[1]; j++)
                {
                    if (lattice[i, j] == 1)
                    {
                        matrix[i, j] = phrase[start];
                        start++;
                    }
                }
            }
        }
    }
}
