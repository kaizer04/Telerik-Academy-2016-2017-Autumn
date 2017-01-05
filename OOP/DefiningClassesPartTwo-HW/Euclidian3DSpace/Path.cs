namespace Euclidian3DSpace
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        List<Point3D> paths;

        public Path()
        {
            paths = new List<Point3D>();
        }

        public void AddPoint()
        {
            this.paths.Add(Point3D.PointO);
        }

        public void AddPoint(Point3D point)
        {
            this.paths.Add(point);
        }

        public void AddPoint(int x, int y, int z)
        {
            this.paths.Add(new Point3D(x, y, z));
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            int pathIndexer = 1;
            foreach (Point3D point in this.paths)
            {
                str.AppendFormat("Point {0} --> ", pathIndexer);
                pathIndexer++;
                str.AppendFormat("{0} , {1} , {2} \r\n", point.X, point.Y, point.Z);
            }

            return str.ToString();
        }
    }
}
