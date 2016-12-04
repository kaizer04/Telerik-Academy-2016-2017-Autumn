namespace SumIntegers
{
    using System;

    public class Program
    {
        private static int CalculateSumFromString(string inputLine)
        {
            // List<int> listOfNumbers = new List<int>();
            char[] whitespace = new char[] { ' ', '\t' };
            string[] inputArray = inputLine.Split(whitespace);
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                sum = sum + int.Parse(inputArray[i]);
            }

            return sum;
        }

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            int sum = CalculateSumFromString(inputLine);

            Console.WriteLine(sum);
        }
    }
}