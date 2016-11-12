namespace BitsToBits
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int maxZeroCount = 0;
            int currentZeroCount = 0;

            int maxOneCount = 0;
            int currentOneCount = 0;

            int lastBit = 5;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 29; j >= 0; j--)
                {
                    int bit = ((1 << j) & num) >> j;
                    //Console.Write(bit);

                    if (bit == 1)
                    {
                        if (lastBit == 1)
                        {
                            currentOneCount++;
                        }
                        else
                        {
                            maxZeroCount = Math.Max(maxZeroCount, currentZeroCount);
                            currentZeroCount = 0;
                            currentOneCount = 1;
                        }
                    }
                    else // bit == 0
                    {
                        if (lastBit == 0)
                        {
                            currentZeroCount++;
                        }
                        else
                        {
                            maxZeroCount = Math.Max(maxZeroCount, currentZeroCount);
                            currentOneCount = 0;
                            currentZeroCount = 1;
                        }

                        lastBit = 9;
                    }
                }

                //Console.WriteLine();
            }
        }
    }
}
