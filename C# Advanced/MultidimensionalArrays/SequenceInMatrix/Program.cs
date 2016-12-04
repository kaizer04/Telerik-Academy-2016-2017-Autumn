namespace SequenceInMatrix
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Enter the size of the matrix N x M (N>=3 & M >=3)\nN = ");
            string inputMatrixLength = Console.ReadLine();
            string[] operands = Regex.Split(inputMatrixLength, @"\s+");
            int n = int.Parse(operands[0]);
            int m = int.Parse(operands[1]);

            // Declare and initialize the matrix
            string[,] matrix = new string[n, m];
            // Console.WriteLine("Enter the matrix {0} rows x {1} columns:", n, m);
            for (int i = 0; i < n; i++)
            {
                string rowInputLine = Console.ReadLine(); // ex. 1 2 3
                string[] emptySpace = new string[] { " " }; // remove from split empty space
                string[] colStrArray = rowInputLine.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < colStrArray.Length; j++)
                {
                    matrix[i, j] = colStrArray[j]; // Input in array
                }
            }

            int count = 1;
            int bestCount = 0;
            int bestRow = 0;
            int bestCol = 0;

            //проверка по редове
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }

                count = 1;
            }

            //проверка по колони
            for (int col = 0; col < m; col++)
            {
                for (int row = 0; row < n - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }

                count = 1;
            }

            //проверка по диагонал отляво надолу и надясно и над него
            for (int i = 0; i < m - 1; i++)
            {
                for (int row = 0, col = i; row < n - 1 && col < m - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }

                count = 1;
            }

            //проверка по диагонал отляво надолу и надясно и под него
            for (int i = 0; i < n - 1; i++)
            {
                for (int row = i + 1, col = 0; row < n - 1 && col < m - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }

                count = 1;
            }

            //other diagonal - отдясно надолу и наляво над него
            for (int i = m - 1; i > 0; i--)
            {
                for (int row = 0, col = i; row < n - 1 && col > 0; row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }

                count = 1;
            }

            //other diagonal - отляво нагоре и надясно и под него
            for (int i = n - 1; i > 0; i--)
            {
                for (int row = n - 1, col = 0; row > 0 && col < m - 1; row--, col++)
                {
                    if (matrix[row, col] == matrix[row - 1, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRow = row;
                        bestCol = col;
                    }
                }

                count = 1;
            }
            
            Console.Write(bestCount);
        }
    }
}
