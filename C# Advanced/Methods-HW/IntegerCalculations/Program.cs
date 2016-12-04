namespace IntegerCalculations
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        static int CalculateMinNumber(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int CalculateMaxNumber(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static long CalculateSum(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static double CalculateAverageValue(int[] array)
        {
            long sum = CalculateSum(array);
            double average;
            average = (double)sum / (double)array.Length;
            return average;
        }

        static BigInteger CalculateProduct(int[] array)
        {
            BigInteger product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }
        
        static void Main()
        {
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(CalculateMinNumber(arrayOfNumbers));

            Console.WriteLine(CalculateMaxNumber(arrayOfNumbers));

            Console.WriteLine("{0:F2}", CalculateAverageValue(arrayOfNumbers));

            Console.WriteLine(CalculateSum(arrayOfNumbers));

            Console.WriteLine(CalculateProduct(arrayOfNumbers));
        }
    }
}
