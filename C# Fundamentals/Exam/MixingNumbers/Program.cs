using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            List<int> mixedNumbers = new List<int>();
            List<int> subtractNumbers = new List<int>();
            for (int i = 0; i < n - 1; i++)
            {
                int a = inputArray[i] % 10;
                int b = inputArray[i + 1] / 10;
                mixedNumbers.Add(a * b);
                
                subtractNumbers.Add(Math.Abs(inputArray[i] - inputArray[i + 1]));
            }

            Console.WriteLine(String.Join(" ", mixedNumbers));
            Console.WriteLine(String.Join(" ", subtractNumbers));
        }
    }
}
