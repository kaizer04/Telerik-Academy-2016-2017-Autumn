/*Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.*/
namespace NumberComparer
{
    using System;
    public class GreaterNumber
    {
        public static void Main()
        {
            double x;
            double y;
            // Console.Write("Please, enter the numbers to find which of them is greater:\nx = ");
            x = double.Parse(Console.ReadLine());
            // Console.Write("y = ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(x > y ? x : y);
        }
    }
}
