namespace MythicalNumbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string inputNumber = Console.ReadLine();

            double[] digits = new double[3];
            for (int i = 0; i < 3; i++)
            {
                digits[i] = double.Parse(inputNumber[i].ToString());
            }

            double result = 0;
            if (digits[2] == 0)
            {
                result = digits[0] * digits[1];
            }
            else if (digits[2] <= 5)
            {
                result = (digits[0] * digits[1]) / digits[2];
            }
            else 
            {
                result = (digits[0] + digits[1]) * digits[2];
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}