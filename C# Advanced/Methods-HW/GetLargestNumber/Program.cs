namespace GetLargestNumber
{
    /* Write a method GetMax() with two parameters that returns the bigger of two integers.Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

    using System;

    public class Program
    {
        static int GetMax(int x1, int x2)
        {
            // int max = x1;
            if (x2 > x1)
            {
                return x2;
            }

            return x1;
        }

        public static void Main()
        {
            // Console.Write("Prints the biggest integer numbers of 3 entered\nEnter the fist integer: ");
            string inputLine = Console.ReadLine(); // ex. 1 2 3
            string[] emptySpace = new string[] { " " }; // remove from split empty space
            string[] inputStringNumbers = inputLine.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(inputStringNumbers[0]);
            // Console.WriteLine("Enter the second integer: ");
            int b = int.Parse(inputStringNumbers[1]);
            // Console.WriteLine("Enter the third integer: ");
            int c = int.Parse(inputStringNumbers[2]);
            // Console.WriteLine();
            Console.WriteLine(GetMax(a, GetMax(b, c)));
            //Console.WriteLine("The biggest integer number is " + max);
        }
    }
}
