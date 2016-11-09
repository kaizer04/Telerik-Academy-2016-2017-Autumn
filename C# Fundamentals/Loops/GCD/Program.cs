namespace GCD
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Calculates the greatest common divisor (GCD) of given two numbers\nPlease, enter two numbers, for which you want to calculate GCD\na = ");
            // int a = int.Parse(Console.ReadLine());
            // Console.Write("b = ");
            // int b = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            char[] whitespace = new char[] { ' ', '\t' };
            string[] inputArray = inputString.Split(whitespace);
            int a = int.Parse(inputArray[1]);
            int b = int.Parse(inputArray[0]);
            int c = 1;
            while (c != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            Console.WriteLine(a);
        }
    }
}
