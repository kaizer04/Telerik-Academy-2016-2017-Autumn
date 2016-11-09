namespace FibonacciNumbers
{
    using System;
    // using System.Numerics;

    class First100MembersOfFibonacci
    {
        static void Main()
        {
            long x1 = 0;
            long x2 = 1;
            long x3;
            int n = int.Parse(Console.ReadLine());
            // Console.WriteLine("The first 100 members of the sequence of Fibonacci:");
            Console.Write("{0}", x1);
            if (n > 1)
            {
                Console.Write(", {0}", x2);
                for (int i = 3; i <= n; i++)
                {
                    x3 = x1 + x2;
                    x1 = x2;
                    x2 = x3;
                    Console.Write(", {0}", x3);
                }
            }

            
        }
    }
}
