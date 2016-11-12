using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpJump
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = Console.ReadLine();
            //Console.WriteLine(instructions);
            char[] arrayOfInstructions = new char[instructions.Length];
            for (int i = 0; i < instructions.Length; i++)
            {
                arrayOfInstructions[i] = instructions[i];
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(arrayOfInstructions[i]);
            //}
            int position = 0;
            char symbol = arrayOfInstructions[position];

            while (true)
            {
                //if (position < 0 && position >= arrayOfInstructions.Length - 1)
                //{
                //    Console.WriteLine("Fell off the dancefloor at {0}!", position);
                //    break;
                //}
                if (symbol == '^')
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", position);
                    break;
                }
                else if (symbol == '0')
                {
                    Console.WriteLine("Too drunk to go on after {0}!", position);
                    break;
                }
                else 
                {
                    int digit = int.Parse(symbol.ToString());
                    //Console.WriteLine(digit);
                    //break;
                    if (digit % 2 == 0)
                    {
                        position = position + int.Parse(symbol.ToString());
                    }
                    else
                    {
                        position = position - int.Parse(symbol.ToString());
                    }

                    if (position > 0 && position <= arrayOfInstructions.Length - 1)
                    {
                        symbol = arrayOfInstructions[position];
                    }
                    else
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", position);
                        break;
                    }
                }
            }

            //for (int i = 0; i < length; i++)
            //{
            //    switch (switch_on)
            //    {
            //        default:
            //    }
            //}
            
        }
    }
}
