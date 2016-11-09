namespace _3rdBit
{
    using System;
    
    public class ThirdBit
    {
        public static void Main()
        {
            int number;
            int y = 1;
            int position = 3;
            // Console.Write("Please, enter a number v = ");
            number = int.Parse(Console.ReadLine());
            // Console.Write("Please, enter a position p = ");
            // p = int.Parse(Console.ReadLine());
            int mask = y << position;
            Console.WriteLine((number & mask) != 0 ? 1 : 0);
            // Console.WriteLine("v = {1}, p = {0}, -> {2}", position, number, (number & mask) != 0 ? true : false);
        }
    }
}
