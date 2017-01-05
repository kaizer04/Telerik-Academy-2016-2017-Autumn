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
            ProblemFour();
        }

        private static void ProblemFour()
        {
            Path test1 = new Path();
            test1.AddPoint();
            test1.AddPoint(new Point3D(1, 2, 3));
            test1.AddPoint(4, 5, 6);


            Console.WriteLine(test1); // testing toString for a path

            PathStorage.WritePathToFile("test.txt", test1);

            //find the file at DefiningClassesPartTwo-HW\Euclidian3DSpace\bin\Debug
            Path readFromFile = PathStorage.ReadPathFromFile("test.txt");

            Console.WriteLine(readFromFile);
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
