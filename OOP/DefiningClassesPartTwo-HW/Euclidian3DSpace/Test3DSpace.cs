namespace Euclidian3DSpace
{
    using System;

    public class Test3DSpace
    {
        public static void Main()
        {
            ProblemOne();
            ProblemTwo();
            ProblemThree();
        }

        private static void ProblemThree()
        {
            var distance = DistanceBetween3DPoints.CalculateDistance(Point3D.PointO, new Point3D(1, 2, -0.5f));
            Console.WriteLine(distance);
        }

        private static void ProblemTwo()
        {
            var startPoint = Point3D.PointO;
            Console.WriteLine(startPoint);
        }

        private static void ProblemOne()
        {
            var point = new Point3D(3, 4, 5);
            Console.WriteLine(point);
        }
    }
}
