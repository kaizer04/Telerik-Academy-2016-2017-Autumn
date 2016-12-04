namespace AppearanceCount
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

        static int CountsNumberInArray(int numberToCount, int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (numberToCount == array[i])
                {
                    count++;
                }
            }

            return count;
        }

        public static void Main()
        {
            // Console.Write("Counts how many times given number appears in given array\nEnter the number:");
            int n = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            int[] inputNumbers = FillArray(inputLine);
            int numberToCount = int.Parse(Console.ReadLine());
            Console.WriteLine(CountsNumberInArray(numberToCount, inputNumbers));
        }
    }
}
