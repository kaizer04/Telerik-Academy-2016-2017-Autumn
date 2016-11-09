namespace NumbersFrom1ToN
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Please, enter to which number, you want to print\nn = ");
            uint n = uint.Parse(Console.ReadLine());
            for (uint i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
