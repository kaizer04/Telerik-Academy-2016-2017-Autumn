namespace RotatingMatrixWalk
{
    using System;

    public class RotatingMatrixWalkSolver
    {
        private static readonly int[] MovementsByX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static readonly int[] MovementsByY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        private static int directionIndex;
        private static int nextValueToUse;

        public static void SolveRotatingMatrixWalk(int[,] matrix)
        {
            directionIndex = 0;
            nextValueToUse = 0;

            FillMatrix(matrix);
        }

        private static void FillMatrix(int[,] matrix)
        {
            var nextRowToUse = 0;
            var nextColToUse = 0;

            while (nextValueToUse < matrix.GetLength(0) * matrix.GetLength(1))
            {
                matrix[nextRowToUse, nextColToUse] = ++nextValueToUse;

                if (NextDirectionIsAvailable(matrix, nextRowToUse, nextColToUse))
                {
                    nextRowToUse += MovementsByX[directionIndex];
                    nextColToUse += MovementsByY[directionIndex];
                }
                else
                {
                    FindFirstEmptyCell(matrix, out nextRowToUse, out nextColToUse);
                }
            }
        }

        private static void FindFirstEmptyCell(int[,] matrix, out int rowToUse, out int colToUse)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        rowToUse = row;
                        colToUse = col;
                        ChangeDirection();
                        return;
                    }
                }
            }

            rowToUse = 0;
            colToUse = 0;
        }

        private static void ChangeDirection()
        {
            directionIndex++;
            if (directionIndex == MovementsByX.Length)
            {
                directionIndex = 0;
            }
        }

        private static bool IsStuck(int[,] matrix, int row, int col)
        {
            var isStuck = row + MovementsByX[directionIndex] < 0 || row + MovementsByX[directionIndex] >= matrix.GetLength(0)
                          || col + MovementsByY[directionIndex] < 0 || col + MovementsByY[directionIndex] >= matrix.GetLength(1)
                          || matrix[row + MovementsByX[directionIndex], col + MovementsByY[directionIndex]] != 0;

            return isStuck;
        }

        private static bool NextDirectionIsAvailable(int[,] matrix, int row, int col)
        {
            var directionChangeTimes = 0;
            while (IsStuck(matrix, row, col))
            {
                ChangeDirection();
                directionChangeTimes++;

                if (directionChangeTimes == MovementsByX.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
