namespace MixingNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int lengthOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[lengthOfArray];
            for (int i = 0; i < lengthOfArray; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            List<int> mixedNumbers = new List<int>();
            List<int> subtractNumbers = new List<int>();
            for (int i = 0; i < lengthOfArray - 1; i++)
            {
                int a = numbers[i] % 10;
                int b = numbers[i + 1] / 10;
                mixedNumbers.Add(a * b);
                
                subtractNumbers.Add(Math.Abs(numbers[i] - numbers[i + 1]));
            }

            Console.WriteLine(string.Join(" ", mixedNumbers));
            Console.WriteLine(string.Join(" ", subtractNumbers));
        }
    }
}