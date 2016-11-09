/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
namespace PointCircleRectangle
{
    using System;

    public class CheckPointCircleAndRectangle
    {
        public static void Main()
        {
            float x;
            float y;
            // Console.Write("Enter point`s coordinates:\nx = ");
            x = float.Parse(Console.ReadLine());
            // Console.Write("y = ");
            y = float.Parse(Console.ReadLine());
            bool isInsideRectangle = (((x <= 5) && (x >= -1)) && ((y <= 1) && (y >= -1)));
            bool isInsideCircle = ((((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= 1.5 * 1.5);
            Console.Write(isInsideCircle ? "inside circle " : "outside circle ");
            Console.WriteLine(isInsideRectangle ? "inside rectangle" : "outside rectangle");
        }
    }
}