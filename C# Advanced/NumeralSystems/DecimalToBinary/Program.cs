namespace DecimalToBinary
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Convert decimal numbers to their binary representation");
            // Console.Write("Enter decimal number: ");
            long number = long.Parse(Console.ReadLine());
            long decimalNumber = number;
            // if (number == 0)
            // {
            //     Console.Write(numberIn);
            // }

            List<long> array = new List<long>();
            while (number > 0)
            {
                array.Add(number % 2);
                number = number / 2;
            }

            array.Reverse();

            for (int i = 0; i < array.Count; i++)
            {
                Console.Write("{0}", array[i]);
            }

            Console.WriteLine();
        }
    }
}