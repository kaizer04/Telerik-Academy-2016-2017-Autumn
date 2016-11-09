using System;

namespace SumOfNNumbers
{
    public class Program
    {
        public static void Main()
        {
            int i = 1;
            int sum = 0;
            int number = 0;
            // Console.Write("Please, enter how many numbers you want to calculate\nn = ");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                // Console.Write("V{0} = ", i);
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}
