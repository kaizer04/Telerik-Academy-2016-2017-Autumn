/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.*/
namespace NthBit
{
    using System;
    
    public class Program
    {
        public static void Main()
        {
            long number;
            int y = 1;
            int position;
            // Console.Write("Please, enter a number v = ");
            number = long.Parse(Console.ReadLine());
            // Console.Write("Please, enter a position p = ");
            position = int.Parse(Console.ReadLine());
            if (position > 28)
            {
                Console.WriteLine("0");
            }
            else
            {
                long mask = y << position;
                Console.WriteLine((number & mask) != 0 ? 1 : 0);
            }
            // Console.WriteLine("v = {1}, p = {0}, -> {2}", p, v, (v & mask) != 0 ? true : false);
        }
    }
}
