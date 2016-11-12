using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> output = new List<char>();
            for (int i = 0; i < input.Length; i+=7)
            {
                output.Add(input[i]);
            }

            foreach (var item in output)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
