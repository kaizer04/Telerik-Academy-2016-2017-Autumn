namespace DivisableBy7and3
{
    using System;
    using System.Linq;

    public class DivisableBy7and3
    {
        public static int[] arrayNumbers = new int[] { 35, 14, 15, 70, -17, 333, 245, 63, 35, 231, 35, 0, 21 };

        public static void NumbersDivisableBy3and7Lambda()
        {
            var numbersDivisableBy3and7 = arrayNumbers.Where(num => num % 3 == 0 && num % 7 == 0);

            foreach (var item in numbersDivisableBy3and7)
            {
                Console.WriteLine(item);
            }
        }

        public static void NumbersDivisableBy3and7LINQ()
        {
            var numbersDivisableBy3and7 = from num in arrayNumbers
                                          where num % 3 == 0 && num % 7 == 0
                                          select num;

            foreach (var item in numbersDivisableBy3and7)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main()
        {
            NumbersDivisableBy3and7Lambda();

            NumbersDivisableBy3and7LINQ();
        }
    }
}