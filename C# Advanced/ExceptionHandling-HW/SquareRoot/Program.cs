namespace SquareRoot
{
    using System;

    public class Program
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }

            return Math.Sqrt(value);
        }

        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F3}", Sqrt(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}