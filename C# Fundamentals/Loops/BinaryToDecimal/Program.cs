namespace BinaryToDecimal
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static long CalculateDegree(long n, int degree)
        {
            long sumDegree = 1;
            for (int i = 1; i <= degree; i++)
            {
                sumDegree *= n;
            }
            return sumDegree;
        }

        public static void Main()
        {
            string inputBinary = Console.ReadLine();
            List<int> array = new List<int>();
            for (int i = inputBinary.Length - 1; i >= 0; i--)
            {
                array.Add(int.Parse(inputBinary[i].ToString()));
            }

            long sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                sum += array[i] * CalculateDegree(2, i);
            }

            Console.WriteLine(sum);
        }
    }
}
