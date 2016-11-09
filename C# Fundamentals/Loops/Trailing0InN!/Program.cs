namespace Trailing0InN_
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Calculates N!/K!\nPlease, enter a number for N and K, (1<K<N):\nN = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int tempSum = 1;
            for (int i = 1; i <= n; i++)
            {
                tempSum = n / Convert.ToInt32(Math.Floor((Math.Pow(5, i))));
                sum = sum + tempSum;
                if (tempSum <= 1)
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
