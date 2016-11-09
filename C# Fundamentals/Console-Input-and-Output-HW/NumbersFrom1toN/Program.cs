namespace NumbersFrom1toN
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int i;
            // Console.Write("Please, enter to which number you want to print\nn = ");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
