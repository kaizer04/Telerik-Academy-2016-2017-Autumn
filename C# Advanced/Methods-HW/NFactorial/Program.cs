namespace NFactorial
{
    using System;

    public class Program
    {
        static void MultiplyNumbers(int n)
        {
            int[] arraySum = new int[200];
            int[] arraySum1 = new int[200];
            int[] arraySum2 = new int[200];
            int n1 = n;
            arraySum[0] = 1;
            if (n == 100)
            {
                n = 99;
            }

            for (int j = n; j > 1; j--)
            {
                int carry = 0;
                int carry1 = 0;
                int carry2 = 0;
                int[] arrayN = ConvertNumberToArray(j);
                for (int i = 0; i < 1; i++)
                {
                    for (int k = 0; k < arraySum.Length; k++)
                    {
                        arraySum1[k] = (arrayN[i] * arraySum[k] + carry1) % 10;
                        carry1 = (arrayN[i] * arraySum[k] + carry1) / 10;
                    }

                }

                // Console.WriteLine("sum1 = " + arraySum1[0]);
                for (int i = 1; i < 2; i++)
                {
                    for (int k = 0; k < arraySum.Length; k++)
                    {
                        arraySum2[k] = (arrayN[i] * arraySum[k] + carry2) % 10;
                        carry2 = (arrayN[i] * arraySum[k] + carry2) / 10;
                    }
                    // Console.WriteLine("sum2 = " + arraySum2[0]);
                }

                arraySum[0] = arraySum1[0];
                for (int i = 0; i < arraySum1.Length - 1; i++)
                {
                    arraySum[i + 1] = (arraySum1[i + 1] + arraySum2[i] + carry) % 10;
                    carry = (arraySum1[i + 1] + arraySum2[i] + carry) / 10;
                }

                //    Console.WriteLine("sum = " + arraySum[0]);
            }

            //Console.Write("{0,3}! = ", n1);
            for (int i = arraySum.Length - 1; i >= 0; i--) //отпечатвам масива наобратно, за да изглежда като число
            {
                if ((Console.CursorLeft == 0) && (arraySum[i] == 0))    //don't print the nulls at the beginning
                {
                    Console.Write("");
                }
                else
                {
                    Console.Write(arraySum[i]);

                }

                //Console.Write(arraySum[i]);
            }

            if (n1 == 100)     //частен случай при n=100 :) (тъй като алгоритъмът ми е arrayN да е най-много двуцифрено число)
            {
                Console.Write("00");
            }

            Console.WriteLine();
        }

        static int[] ConvertNumberToArray(int j)
        {
            int[] digits = new int[200];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = j % 10;
                j = j / 10;
            }

            return digits;
        }

        static void Main()
        {
            // Console.WriteLine("Calculate N!");
            // Console.Write("Enter N (1<=N<=100): ");
            int n = int.Parse(Console.ReadLine());

            //for (int i = n; i > 1; i--)
            //{
            //    int[] arrayN = ConvertNumberToArray(n);

            //}
            MultiplyNumbers(n);
        }
    }
}