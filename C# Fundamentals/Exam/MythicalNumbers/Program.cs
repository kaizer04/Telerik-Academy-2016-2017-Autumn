using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            //Console.WriteLine(inputNumber);
            double[] arrayOfDigits = new double[3];
            for (int i = 0; i < 3; i++)
            {
                arrayOfDigits[i] = double.Parse(inputNumber[i].ToString());
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arrayOfDigits[i]);
            //}

            double result = 0;
            if (arrayOfDigits[2] == 0)
            {
                result = arrayOfDigits[0] * arrayOfDigits[1];
            }
            else if (arrayOfDigits[2] <= 5)
            {
                result = (arrayOfDigits[0] * arrayOfDigits[1]) / arrayOfDigits[2];
            }
            else 
            {
                result = (arrayOfDigits[0] + arrayOfDigits[1]) * arrayOfDigits[2];
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
