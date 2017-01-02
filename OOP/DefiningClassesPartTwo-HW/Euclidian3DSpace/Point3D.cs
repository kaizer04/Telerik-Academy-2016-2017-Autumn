namespace Euclidian3DSpace
{
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public Point3D(float coordinateX, float coordinateY, float coordinateZ)
        {
            this.X = coordinateX;
            this.Y = coordinateY;
            this.Z = coordinateZ;
        }

        public float X
        {
            get;
            private set;
        }

        public float Y
        {
            get;
            private set;
        }

        public float Z
        {
            get;
            private set;
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y}, {this.Z})";
        }
    }
}
