namespace JumpJump
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string instructions = Console.ReadLine();
            char[] arrayOfInstructions = new char[instructions.Length];
            for (int i = 0; i < instructions.Length; i++)
            {
                arrayOfInstructions[i] = instructions[i];
            }
            
            int position = 0;
            char symbol = arrayOfInstructions[position];

            while (true)
            {
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
        }
    }
}
