/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).*/
namespace QuadraticEquation
{
    using System;

    public class QuadraticEquation
    {
        public static void Main()
        {
            double a;
            double b;
            double c;
            // Console.Write("Please, enter the coefficients a, b and c of a quadratic equation ax2+bx+c=0:\na = ");
            a = double.Parse(Console.ReadLine());
            // Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            // Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            if ((b * b - 4 * a * c) > 0)
            {
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("{0:F2}", x2);
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("{0:F2}", x1);
            }
            else
            {
                if ((b * b - 4 * a * c) == 0)
                {
                    double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                    Console.WriteLine("{0:F2}", x1);
                }
                else
                {
                    Console.WriteLine("no real roots");
                }
            }
        }
    }
}
