namespace MergeSort
{
    using System;

    public class Program
    {
        private static void ChekIsEqual(int n, int[] array, int j)
        {
            for (int i = 0; i < n; i += 2)
            {
                if (array[i + 1] < array[i])
                {
                    Swap(array, i, i + 1);
                }
            }
        }

        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //int[] tempArray = new int[n];
            int j = 2;
            while (j >= n)
            {
                ChekIsEqual(n, array, j);

                j *= 2;
            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
