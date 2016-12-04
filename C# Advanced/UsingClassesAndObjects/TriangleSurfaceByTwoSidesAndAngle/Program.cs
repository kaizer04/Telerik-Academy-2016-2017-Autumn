namespace TriangleSurfaceByTwoSidesAndAngle
{
    using System;

    public class Program
    {
        static void SideAndAltitude()
        {
            // Console.WriteLine("1. Side and an altitude to it");
            // Console.Write("Enter side: ");
            double sideA = double.Parse(Console.ReadLine());

            // Console.Write("Enter altitude: ");
            double altitudeA = double.Parse(Console.ReadLine());

            double surface = (sideA * altitudeA) / 2;
            Console.WriteLine("{0:F2}", surface);
        }

        static void ThreeSides()
        {
            //Console.WriteLine("2. Three sides");
            //Console.Write("Enter first side: ");
            double sideA = double.Parse(Console.ReadLine());

            //Console.Write("Enter second side: ");
            double SideB = double.Parse(Console.ReadLine());

            //Console.Write("Enter third side: ");
            double sideC = double.Parse(Console.ReadLine());

            double semiPerimeter = (sideA + SideB + sideC) / 2;
            double surface = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - SideB) * (semiPerimeter - sideC));
            Console.WriteLine("{0:F2}", surface);
        }

        static void TwoSidesAndAngle()
        {
            //Console.WriteLine("3. Two sides and an angle between them");
            //Console.Write("Enter first side: ");
            double sideA = double.Parse(Console.ReadLine());

            //Console.Write("Enter second side: ");
            double sideB = double.Parse(Console.ReadLine());

            //Console.Write("Enter angle: ");
            double angleAB = double.Parse(Console.ReadLine());

            double surface = (sideA * sideB * Math.Sin(Math.PI * angleAB / 180)) / 2;
            Console.WriteLine("{0:F2}", surface);
        }

        static void Main()
        {
            // Console.WriteLine("Calculate the surface of a triangle by given:");
            // Console.WriteLine("1. Side and an altitude to it;");
            // Console.WriteLine("2. Three sides;");
            // Console.WriteLine("3. Two sides and an angle between them.");
            // Console.Write("Enter your choise: ");
            int task = 3;
            // Console.WriteLine();

            switch (task)
            {
                case 1:
                    SideAndAltitude();
                    break;
                case 2:
                    ThreeSides();
                    break;
                case 3:
                    TwoSidesAndAngle();
                    break;
                default:
                    Console.WriteLine("Wrong choise. Try again!");
                    Main();
                    break;
            }
        }
    }
}
