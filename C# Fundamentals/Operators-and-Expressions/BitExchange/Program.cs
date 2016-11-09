/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

namespace BitExchange
{
    
    using System;

    public class BitExchange
    {
        public static void Main()
        {
            uint i; // 00000000000000000000000111001000
                    // 00000001000000000000000111000000
                    // 00000000011101110110000100100110 
                    // 00000100011101110110000100000110
            uint y = 1;
            // Console.Write("Please, enter a number i = ");
            i = uint.Parse(Console.ReadLine());
            uint mask3 = y << 3;
            int v3 = ((i & mask3) != 0 ? 1 : 0);
            uint mask24 = y << 24;
            int v24 = ((i & mask24) != 0 ? 1 : 0);
            int v324 = v3;
            v3 = v24;
            v24 = v324;
            if (v3 == 0)
            {
                i = i & (~mask3);
            }
            else
            {
                i = i | (mask3);
            }
            if (v24 == 0)
            {
                i = i & (~mask24);
            }
            else
            {
                i = i | (mask24);
            }
            uint mask4 = y << 4;
            int v4 = ((i & mask4) != 0 ? 1 : 0);
            uint mask25 = y << 25;
            int v25 = ((i & mask25) != 0 ? 1 : 0);
            int v425 = v4;
            v4 = v25;
            v25 = v425;
            if (v4 == 0)
            {
                i = i & (~mask4);
            }
            else
            {
                i = i | (mask4);
            }
            if (v25 == 0)
            {
                i = i & (~mask25);
            }
            else
            {
                i = i | (mask25);
            }
            uint mask5 = y << 5;
            int v5 = ((i & mask5) != 0 ? 1 : 0);
            uint mask26 = y << 26;
            int v26 = ((i & mask26) != 0 ? 1 : 0);
            int v526 = v5;
            v5 = v26;
            v26 = v526;
            if (v5 == 0)
            {
                i = i & (~mask5);
            }
            else
            {
                i = i | (mask5);
            }
            if (v26 == 0)
            {
                i = i & (~mask26);
            }
            else
            {
                i = i | (mask26);
            }
            Console.WriteLine(i);
            //Console.WriteLine("i = {1}, p = {0}, -> value = {2}", p, i, (i & mask) != 0 ? 1 : 0);
        }
    }

}
