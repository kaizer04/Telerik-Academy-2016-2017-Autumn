namespace FirstLargerThanNeighbours
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static int[] FillArray(string inputLine)
        {
            string[] emptySpace = new string[] { " " }; // remove from split empty space
            string[] stringArrayOfNumbers = inputLine.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayOfNumbers = new int[stringArrayOfNumbers.Length];
            for (int i = 0; i < stringArrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = int.Parse(stringArrayOfNumbers[i]); // Input digits in array
            }

            return arrayOfNumbers;
        }

        static bool CheckPosition(int pos, int n)
        {
            if (pos <= 0 || pos >= n - 1)
            {
                Console.WriteLine("Enter a correct position!");
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool CheckAreNeighborsBigger(int position, int[] array)
        {
            CheckPosition(position, array.Length);
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int ReturnIndexOfElementIfNeighborsBigger(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (CheckAreNeighborsBigger(i, array))
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            int[] inputNumbers = FillArray(inputLine);

            Console.WriteLine(ReturnIndexOfElementIfNeighborsBigger(inputNumbers));
        }
    }
}
