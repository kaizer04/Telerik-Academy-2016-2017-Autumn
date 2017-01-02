namespace Euclidian3DSpace
{
    using System;

    public static class DistanceBetween3DPoints
    {
        public static float CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            return (float)Math.Sqrt(
                (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z)
                );
        }
    }
}
