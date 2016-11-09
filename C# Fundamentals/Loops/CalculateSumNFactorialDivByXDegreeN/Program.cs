namespace CalculateSumNFactorialDivByXDegreeN
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Calculates S = 1 + 1!/X + 2!/X^2 + … + N!/X^N\nPlease, enter an integer number for N and X, (N>0):\nN = ");
            int n = int.Parse(Console.ReadLine());
            // Console.Write("X = ");
            double x = double.Parse(Console.ReadLine());
            double sumNDivX = 1;
            double sumN = 1;
            double sumX = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sumN *= i;
                sumX *= x;
                sumNDivX = (sumN / sumX);
                sum += sumNDivX;
            }
                
            // Console.WriteLine("S = 1 + 1!/X + 2!/X^2 + ... + N!/X^N = {0}", s);
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
