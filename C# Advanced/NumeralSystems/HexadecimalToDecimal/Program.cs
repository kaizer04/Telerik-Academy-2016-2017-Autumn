namespace HexadecimalToDecimal
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static long CalculateDegree(long n, int degree)
        {
            long sumDegree = 1;
            for (int i = 1; i <= degree; i++)
            {
                sumDegree *= n;
            }

            return sumDegree;
        }

        static long ConvertCharToDigit(char element)
        {
            long digit = 0;
            switch (element)
            {
                case 'A':
                case 'a':
                    digit = 10;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    break;
                default:
                    digit = int.Parse(Convert.ToString(element));
                    break;
            }

            return digit;
        }

        static string ConvertDigitToChar(long n)
        {
            string ch = string.Empty;
            switch (n)
            {
                case 10:
                    ch = "A";
                    break;
                case 11:
                    ch = "B";
                    break;
                case 12:
                    ch = "C";
                    break;
                case 13:
                    ch = "D";
                    break;
                case 14:
                    ch = "E";
                    break;
                case 15:
                    ch = "F";
                    break;
            }

            return ch;
        }


        static void Main(string[] args)
        {
            // Console.WriteLine("Convert from given base s to numeral system of base d (2 <= s, d <= 16)");
            // Console.Write("Enter base s: ");
            long numeralSystemBaseS = 16;
            string number = Console.ReadLine();
            // Console.Write("Enter base d: ");
            long numeralSystemBaseD = 10;
            // Console.Write("The digits of number which you want to convert from s to d must be >= 0 and < {0}\nEnter a number: ", s);


            string numebrOfNumeralSystemBaseS = number;
            long sumDecimal = 0;

            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                sumDecimal += ConvertCharToDigit(number[i]) * CalculateDegree(numeralSystemBaseS, j);
            }

            List<long> array = new List<long>();
            while (sumDecimal > 0)
            {
                array.Add(sumDecimal % numeralSystemBaseD);
                sumDecimal = sumDecimal / numeralSystemBaseD;
            }

            array.Reverse();
            // Console.Write("The converted of {0} from base {1} to numeral system of base {2} is ", numberIn, s, d);
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] > 9)
                {
                    Console.Write("{0}", ConvertDigitToChar(array[i]));
                }
                else
                {
                    Console.Write("{0}", array[i]);
                }

            }

            Console.WriteLine();
        }
    }
}
