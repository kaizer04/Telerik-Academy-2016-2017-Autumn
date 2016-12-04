namespace SortingArray
{
    using System;
    using System.Linq;

    public class Program
    {
        static int ReturnMaxElement(int n, int index)
        {
            int[] array = new int[n];
            FillArray(array);
            int max = array[index];
            for (int i = index; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        static void FillArray(int[] array)
        {
            Console.WriteLine("FILL the array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Main()
        {
            // Console.WriteLine("Return the maximal element in a portion of array of integers starting at given index");
            // Console.Write("Enter array`s lenght: ");
            int n = int.Parse(Console.ReadLine());
            // Console.Write("Enter the staritng index (<{0}): ", n);
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int index = 0;
            //int max = ReturnMaxElement(n, index);
            //Console.WriteLine("The maximal element is {0}", max);
            //Console.WriteLine();
            //Console.WriteLine("Sort the array in descending order");
            int[] sortedArray = SortArray(array);
            // descending order
            // PrintArray(SortArray(array));
            // ascending  order
            Array.Reverse(sortedArray);
            PrintArray(sortedArray);
        }

        static int[] SortArray(int[] array)
        {
            // int[] sortedArray = new int[n];
            // FillArray(array);
            int max;
            for (int i = 0; i < array.Length; i++)
            {
                max = array[i];
                array = ReturnMaxElement(i, max, array);
            }

            return array;
        }

        static int[] ReturnMaxElement(int index, int max, int[] array)
        {
            for (int j = index + 1; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    array[j] = array[index];
                    array[index] = max;
                }
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }
}