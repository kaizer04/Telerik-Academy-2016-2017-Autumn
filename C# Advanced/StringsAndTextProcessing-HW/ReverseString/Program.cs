namespace ReverseString
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            char[] arrayOfChars = inputString.ToCharArray();
            Array.Reverse(arrayOfChars);

            // string printS = new string(revS);
            // Console.Write("Reversed string: ");
            Console.WriteLine(arrayOfChars);
        }
    }
}
