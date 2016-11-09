namespace ComparingFloats
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double a;
            double b;
            double precision = 0.000001f;
            bool compare;
            //Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            //Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            compare = (Math.Abs(a - b) < precision);
            Console.WriteLine(compare ? "true" : "false");
        }
    }
}
