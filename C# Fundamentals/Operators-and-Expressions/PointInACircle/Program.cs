/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).*/
namespace PointInACircle
{
    using System;

    class CheckPointCircle
    {
        static void Main()
        {
            float x;
            float y;
            //float r = 5;
            //Console.Write("Enter point`s coordinates:\nx = ");
            x = float.Parse(Console.ReadLine());
            //Console.Write("y = ");
            y = float.Parse(Console.ReadLine());
            bool isInside = ((x * x) + (y * y)) <= 4;
            double distance = Math.Sqrt(x * x + y * y);
            if (isInside)
            {
                Console.WriteLine("yes {0:F2}", distance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", distance);
            }
        }
    }
}