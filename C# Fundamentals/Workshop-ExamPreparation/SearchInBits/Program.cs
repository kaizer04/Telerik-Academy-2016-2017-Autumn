using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int pos = 0; pos <= 26; pos++)
                {
                    bool match = true;
                    for (int j = 0; j <= 3; j++)
                    {
                        int posInNum = pos + j;
                        int posInS = j;

                        int bitInNum = (num & (1 << posInNum)) >> posInNum;
                        int bitInS = (s & (1 << posInS)) >> posInS;
                        
                        if (bitInNum != bitInS)
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}