/** Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.*/
namespace BitSwap
{
    using System;

    public class BitSwap
    {
        public static void Main()
        {
            uint number; // 00000000000000000000000000000101 i = 5
                    // 01000000000000000000000000000100 new i = 1073741828
            uint y = 1;
            int p;
            int q;
            uint k;
            
            // Console.Write("Please, enter a number i = ");
            number = uint.Parse(Console.ReadLine());
            // Console.Write("Please, enter the start positon of the first bits you want exchange, (0 < = p1 < = 31) p1 = ");
            p = int.Parse(Console.ReadLine());
            //Console.WriteLine("p1 + k = {0}", p1 + k);
            //Console.Write("Please, enter the start positon of the second bits you want exchange, (p1+k < p2 <= 31-k) p2 = ");
            q = int.Parse(Console.ReadLine());
            // Console.Write("Please, enter how many bits you want exchange (0 < k < = 31-p1) k = ");
            k = uint.Parse(Console.ReadLine());
            
            for (int i = 0; i < k; i++)
            {
                uint mask1 = y << (p + i);
                int v1 = ((number & mask1) != 0 ? 1 : 0);
                uint mask2 = y << (q + i);
                int v2 = ((number & mask2) != 0 ? 1 : 0);
                int v = v1;
                v1 = v2;
                v2 = v;
                if (v1 == 0)
                {
                    number = number & (~mask1);
                }
                else
                {
                    number = number | (mask1);
                }
                if (v2 == 0)
                {
                    number = number & (~mask2);
                }
                else
                {
                    number = number | (mask2);
                }
            }
            Console.WriteLine(number);
            //Console.WriteLine("i = {1}, p = {0}, -> value = {2}", p, i, (i & mask) != 0 ? 1 : 0);
        }
    }
}
