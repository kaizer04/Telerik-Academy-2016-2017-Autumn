namespace NotDivisibleNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Please, enter to which number, you want to print numbers not divisible by 3 and 7\nn = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
