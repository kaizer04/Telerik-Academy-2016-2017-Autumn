namespace EnglishDigit
{
    using System;

    public class Program
    {
        static string ReturnDigitAsWord(int digit)
        {
            string[] digitsAsWord = new string[]
            {
                "zero", "one", "two", "three", "four", "five", "six",
                "seven", "eight", "nine"
            };
            string digitAsWord = digitsAsWord[digit];

            return digitAsWord;
        }

        static string ReturnsLastDigitAsWord(int number)
        {
            int lastDigit = Math.Abs(number % 10);

            return ReturnDigitAsWord(lastDigit);
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnsLastDigitAsWord(number));
        }
    }
}
