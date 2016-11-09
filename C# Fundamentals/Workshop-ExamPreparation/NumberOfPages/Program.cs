namespace NumberOfPages
{
    using System;

    public class Program
    {
        private static int TakeResult(int digits, int i)
        {
            int degreeOfTen = 1;
            for (int j = 0; j < i; j++)
            {
                degreeOfTen *= 10;
            }

            return digits - 9 * degreeOfTen * i ;
        }

        public static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int i = 1;
            while (digits > 0)
            {
                digits = TakeResult(digits, i);
                    //9x1
                    //90x2
                    //900x3
                    //9000x4
                    //90000x5
                    //900000x6
            }
        }
   }
}
