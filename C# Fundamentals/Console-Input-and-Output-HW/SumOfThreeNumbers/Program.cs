/*Write a program that reads 3 integer numbers from the console and prints their sum.*/
namespace SumOfThreeNumbers
{
    
    using System;
    
    public class Program
    {
        public static void Main()
        {
            // Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            // Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            // Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(a + b + c);
        }
    }
}