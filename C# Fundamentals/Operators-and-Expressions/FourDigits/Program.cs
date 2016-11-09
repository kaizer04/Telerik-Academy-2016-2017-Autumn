namespace FourDigits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int a, b, c, d;
            int number = int.Parse(Console.ReadLine());
            d = number % 10;
            c = number / 10 % 10;
            b = number / 100 % 10;
            a = number / 1000 % 10;
            int sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
