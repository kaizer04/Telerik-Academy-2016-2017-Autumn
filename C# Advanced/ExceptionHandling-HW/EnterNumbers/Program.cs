namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static int lastNumber = 1;
        static List<int> numberInRange = new List<int>();
        const int START = 1;
        const int END = 100;

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            
            if ((number < start) || (number > end) || (number <= lastNumber))
            {
                throw new ArgumentOutOfRangeException();
            }

            lastNumber = number;

            return number;
        }

        static void Main()
        {
            try
            {
                numberInRange.Add(START);
                for (int i = 1; i <= 10; i++)
                {
                    // Console.Write("Enter number {0} in the range [{1}...{2}] : ", i, 1, 100);
                    int number = ReadNumber(START, END);
                    numberInRange.Add(number);
                }

                numberInRange.Add(100);
                Console.WriteLine(string.Join(" < ", numberInRange));
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Exception");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
