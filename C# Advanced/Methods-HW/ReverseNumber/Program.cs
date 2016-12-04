namespace ReverseNumber
{
    using System;

    public class Program
    {
        static string ReverseNumberDigits(string number)
        {
            string reversedNumber = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber = reversedNumber + number[i];
            }

            return reversedNumber;
        }

        public static void Main()
        {
            // Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumberDigits(number));
        }
    }
}
