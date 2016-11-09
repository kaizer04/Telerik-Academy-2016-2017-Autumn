namespace LongSequence
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = 1000;
            int startNumber = 2;
            for (int i = startNumber; i < n + startNumber; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * (-1));
                }
            }
        }
    }
}
