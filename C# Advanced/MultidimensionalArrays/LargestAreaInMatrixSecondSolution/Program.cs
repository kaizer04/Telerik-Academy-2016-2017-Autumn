// solution for 80/100 points in bgcoder
namespace LargestAreaInMatrixSecondSolution
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        static int answer = 0;
        static int absoluteMax = 0;
        // Declare and initialize the matrix
        static short[,] matrix;
        static bool[,] isVisited;

        static short[,] FillMatrix()
        {
            string inputMatrixLength = Console.ReadLine();
            string[] operands = Regex.Split(inputMatrixLength, @"\s+");
            int n = int.Parse(operands[0]);
            int m = int.Parse(operands[1]);
            short[,] matrix = new short[n, m];

            // Console.WriteLine("Enter the matrix {0} rows x {1} columns:", n, m);
            for (int i = 0; i < n; i++)
            {
                string rowInputLine = Console.ReadLine(); // ex. 1 2 3
                string[] emptySpace = new string[] { " " }; // remove from split empty space
                string[] colStrArray = rowInputLine.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < colStrArray.Length; j++)
                {
                    matrix[i, j] = short.Parse(colStrArray[j]); // Input in array
                }
            }

            return matrix;
        }

        public static void Main()
        {
            matrix = FillMatrix();
            isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    FindTheArea(i, j, matrix[i, j]);
                    answer = 0;
                }
            }

            Console.WriteLine(absoluteMax);
        }

        private static void FindTheArea(int i, int j, short currElement)
        {

            if ((i < 0) || (i >= matrix.GetLength(0)) || (j < 0) || (j >= matrix.GetLength(1))) //returns if we are out of the matrix or the element is not the same
            {
                return;
            }

            if (isVisited[i, j] == true)
            {
                return;
            }

            if (matrix[i, j] == currElement)
            {
                isVisited[i, j] = true;

                answer++;

                if (absoluteMax < answer)
                {
                    absoluteMax = answer;
                }

                FindTheArea(i + 1, j, currElement);

                FindTheArea(i - 1, j, currElement);

                FindTheArea(i, j + 1, currElement);

                FindTheArea(i, j - 1, currElement);

                // isVisited[i,j] = false;
                // matrix[i, j] = currElement;

            }
        }
    }
}