namespace LargerThanNeighbours
{
    using System;

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

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            int[] inputNumbers = FillArray(inputLine);
            int count = 0;
            for (int i = 1; i < inputNumbers.Length - 1; i++)
            {
                if (CheckAreNeighborsBigger(i, inputNumbers))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}