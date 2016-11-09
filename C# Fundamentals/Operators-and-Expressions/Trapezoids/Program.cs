/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/
namespace Trapezoids
{
    using System;

    public class TrapezoidArea
    {
        public static void Main()
        {
            // Console.Write("Calculate trapezoid’s area\nEnter side a = ");
            double a = double.Parse(Console.ReadLine());
            // Console.Write("Enter side b = ");
            double b = double.Parse(Console.ReadLine());
            // Console.Write("Enter height h = ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F7}", (a + b) * h / 2);
        }
    }
}
