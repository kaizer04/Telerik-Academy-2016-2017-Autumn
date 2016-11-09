namespace MinMaxSumAvgOfNNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double max = Double.MinValue;
            double min = Double.MaxValue;
            // Console.Write("Please, enter how many integer numbers, in which find the maximum and the minimum number\nn = ");
            int n = int.Parse(Console.ReadLine());
            // Console.Write("Enter a sequence of numbers:\n");
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x <= min)
                {
                    min = x;
                }

                if (x >= max)
                {
                    max = x;
                }

                sum = sum + x;
            }

            double avg = sum / n;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}
