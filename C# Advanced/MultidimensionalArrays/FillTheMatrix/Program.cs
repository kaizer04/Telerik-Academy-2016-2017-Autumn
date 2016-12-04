namespace FillTheMatrix
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Enter the size of the matrix = ");
            int n = int.Parse(Console.ReadLine());
            string howToFill = Console.ReadLine();
            int[,] matrix = new int[n, n];
            switch (howToFill)
            {
                case "a":
                    FillTheMatrixA(n, matrix);
                    break;
                case "b":
                    FillTheMatrixB(n, matrix);
                    break;
                case "c":
                    FillTheMatrixC(n, matrix);
                    break;
                case "d":
                    FillTheMatrixD(n, matrix);
                    break;
                default:
                    Console.WriteLine("Enter a valid case!");
                    break;
            }

            PrintMatrix(n, matrix);
        }

        private static void FillTheMatrixD(int n, int[,] matrix)
        {
            string direction = "down";
            int currentRow = 0;
            int currentCol = 0;

            for (int i = 1; i <= n * n; i++)
            { 
                if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol++;
                    direction = "right";
                }
                else if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow--;
                    direction = "up";
                }
                else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow++;
                    direction = "left";
                }
                else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    currentRow++;
                    direction = "down";
                }

                matrix[currentRow, currentCol] = i;
                
                if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
            }
        }

        private static void FillTheMatrixC(int n, int[,] matrix)
        {
            int row;
            int col;
            int value = 1;

            //populate values under the main diagonal
            for (int i = n - 1; i >= 0; i--)
            {
                row = i;
                col = 0;
                while (row < n && col < n)
                {
                    matrix[row, col] = value;
                    row++;
                    col++;
                    value++;
                }
            }

            //populate values over the main diagonal
            for (int j = 1; j < n; j++)
            {
                row = j;
                col = 0;
                while (row < n && col < n)
                {
                    matrix[col, row] = value;
                    row++;
                    col++;
                    value++;
                }
            }
        }

        private static void FillTheMatrixB(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col = col + 2)
                {
                    matrix[row, col] = row + col * n + 1;

                    //int element = int.Parse(Console.ReadLine());
                    //matrix[row, col] = element;
                }

                for (int col = 1; col < n; col = col + 2)
                {
                    matrix[row, col] = (col + 1) * n - row;

                    //int element = int.Parse(Console.ReadLine());
                    //matrix[row, col] = element;
                }

                //matrix[row, row] = row + n;+ 1
            }

        }

        private static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == n -1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }

        private static void FillTheMatrixA(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = row + col * n + 1;

                    //int element = int.Parse(Console.ReadLine());
                    //matrix[row, col] = element;
                }
                //matrix[row, row] = row + n;+ 1
            }
        }
    }
}
