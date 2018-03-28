using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardanoLattice
{
    class Program
    {
        static void Main(string[] args)
        {
            Lattice obLattice = new Lattice();
            Matrix obMatrix = new Matrix();

            string[] inValue = Console.ReadLine().Split(' ');
            int[] size = inValue.Select(t => int.Parse(t)).ToArray();
            string inText = Console.ReadLine().ToLower().Replace(" ", "");
            int temp = 0;

            int[,] lattice = new int[size[0], size[1]];
            char[,] matrix = new char[size[0], size[1]];
            

            obLattice.Fill(lattice, size);            
            obMatrix.Fill(matrix, size);            
            obMatrix.Repair(matrix, size, inText, temp);           
            obLattice.Repair(lattice, size, inText, temp, matrix);
            obLattice.Print(lattice, size);
            obLattice.Right(lattice, size);
            obMatrix.Repair1(lattice, matrix, size, temp, inText);
            obLattice.Print(lattice, size);
            obLattice.Down(ref lattice, size);
            obMatrix.Repair2(lattice, matrix, size, temp, inText);
            obLattice.Print(lattice, size);
            obLattice.Left(lattice, size);
            obMatrix.Repair3(lattice, matrix, size, temp, inText);
            obLattice.Print(lattice, size);
            obMatrix.Print(matrix, size);

        }
    }
}
