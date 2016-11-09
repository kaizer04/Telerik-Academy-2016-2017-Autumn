using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = row + col + 1;

                    //int element = int.Parse(Console.ReadLine());
                    //matrix[row, col] = element;
                }
                //matrix[row, row] = row + n;+ 1
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
