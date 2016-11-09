/*Write a program that reads the radius r of a circle and prints its perimeter and area.*/
namespace Circle
{

    using System;

    public class CirclePerimeterAndArea
    {
        public static void Main()
        {
            // Console.Write("Please, enter the radius of the circler\nr = ");
            double r = double.Parse(Console.ReadLine());
            // Console.WriteLine();
            Console.Write("{0:F2} ", (2 * Math.PI * r));
            Console.WriteLine("{0:F2} ", (Math.PI * r * r));
        }
    }
}