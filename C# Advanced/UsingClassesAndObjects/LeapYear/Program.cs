namespace LeapYear
{
    using System;

    public class Program
    {
        public static void Main()
        {
            //Console.Write("Enter a year to check is it a leap: ");
            int year = int.Parse(Console.ReadLine());
            //DateTime year = new DateTime(yearIn);

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}