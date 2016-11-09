/*Write an expression that checks if given positive integer number n (n ? 100) is prime. E.g. 37 is prime.*/
namespace PrimeCheck
{
    using System;

    public class CheckPrimeNumber
    {
        public static void Main()
        {
            int n;
            //Console.Write("Enter a numebr n, 0<n<=100:\nn = ");
            n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if ((n > 1) && (n <= 100))
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if ((n % i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }

                Console.WriteLine(isPrime ? "true" : "false");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}