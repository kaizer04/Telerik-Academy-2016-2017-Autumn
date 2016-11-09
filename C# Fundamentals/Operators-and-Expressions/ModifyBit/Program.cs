/*We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
       Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
       n = 5 (00000101), p=2, v=0 -> 1 (00000001)*/
namespace ModifyBit
{
    using System;
   
    public class ModifieValueBit
    {
        public static void Main()
        {
            ulong number;
            int y = 1;
            int position;
            int bitVlue;
            ulong newNumber;
            // Console.Write("Please, enter a number n = ");
            number = ulong.Parse(Console.ReadLine());
            // Console.Write("Please, enter a position p = ");
            position = int.Parse(Console.ReadLine());
            // Console.Write("Please, enter a value for the bit at the position p, (v = 0 or 1) v = ");
            bitVlue = int.Parse(Console.ReadLine());
            ulong mask = (ulong)y << position;
            if (bitVlue == 0)
            {
                newNumber = number & (~mask);
            }
            else
            {
                newNumber = number | (mask);
            }
            //     Console.WriteLine("Please, enter a corect value for v");
            //int mask = y << p;
            //b = (n & mask) != 0 ? 1 : 0);
            Console.WriteLine(newNumber);
        }
    }
}
