namespace ImplementMatrix
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Columns
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }

                return this.matrix[row, col];
            }

            set
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Matrix {0} is null!", firstMatrix == null ? "1" : "2");
            }

            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Matreces must have same dimensions when summing!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Matrix {0} is null!", firstMatrix == null ? "1" : "2");
            }

            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Matreces must have same dimensions when substracting!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
            {
                throw new ArgumentNullException("Matrix {0} is null!", firstMatrix == null ? "1" : "2");
            }

            if (firstMatrix.Rows != secondMatrix.Columns)
            {
                throw new ArgumentException("Matrix 1 rows and Matrix 2 columns must be the same number!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Columns);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Columns; col++)
                {
                    dynamic temp = 0;
                    for (int currentnumbers = 0; currentnumbers < firstMatrix.Columns; currentnumbers++)
                    {
                        temp = temp + (dynamic)firstMatrix[row, currentnumbers] * (dynamic)secondMatrix[currentnumbers, col];
                    }
                    result[row, col] = temp;
                }
            }

            return result;
        }

        //if at least one element is not 0 this should return true
        public static bool operator true(Matrix<T> currentMatrix)
        {
            for (int row = 0; row < currentMatrix.Rows; row++)
            {
                for (int col = 0; col < currentMatrix.Columns; col++)
                {
                    if (currentMatrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> currentMatrix)
        {
            for (int row = 0; row < currentMatrix.Rows; row++)
            {
                for (int col = 0; col < currentMatrix.Columns; col++)
                {
                    if (currentMatrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder toStringer = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    toStringer.Append(this.matrix[i, j] + " ");
                }

                toStringer.Append(Environment.NewLine);
            }

            return toStringer.ToString();
        }
    }
}
