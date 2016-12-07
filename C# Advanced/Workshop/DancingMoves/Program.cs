namespace DancingMoves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static int[] array;
        static string[] instructions;
        static string inputInstructions;
        static long sum = 0;
        static int startIndex = 0;
        static int roundsPlayed = 0;
        static void Main()
        {
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (true)
            {
                inputInstructions = Console.ReadLine();
                if (inputInstructions == "stop")
                {
                    break;
                }
                instructions = inputInstructions.Split(' ').ToArray();
                //Console.WriteLine(String.Join(", ", instructions));
                DancingInArray(instructions);
            }

            Console.WriteLine("{0:F1}", (double)sum / roundsPlayed);
        }

        private static void DancingInArray(string[] instructions)
        {
            int times = int.Parse(instructions[0]);
            string direction = instructions[1];
            int step = int.Parse(instructions[2]);

            //if (direction == "left")
            //{
            //    start = start + 1;
            //    for (int moves = 1, i = start + step; moves <= times; i = i - (step % array.Length), moves++)
            //    {
            //        sum = sum + array[i];
            //        start = i;
            //    }
            //}
            //else
            //{
            //    for (int moves = 1, i = start + step; moves <= times; i = i + (step % array.Length), moves++)
            //    {
            //        sum = sum + array[i];
            //        start = i;
            //    }
            //}
            if (direction == "left")
            {
                while (times > 0)
                {
                    int currentIndex = startIndex - step;
                    if (currentIndex % array.Length < 0)
                    {
                        currentIndex = currentIndex % array.Length + array.Length;
                    }
                    else
                    {
                        currentIndex = currentIndex % array.Length;
                    }

                    sum = sum + array[currentIndex];

                    startIndex = currentIndex;

                    times--;
                }
            }
            else
            {
                while (times > 0)
                {
                    int currentIndex = startIndex + step;
                    if (currentIndex >= array.Length)
                    {
                        currentIndex = currentIndex % array.Length;
                    }

                    sum = sum + array[currentIndex];

                    startIndex = currentIndex;
                    //start = (start + step) % array.Length;
                    //sum = sum + array[start];
                    times--;
                }
            }

            roundsPlayed++;
        }
    }
}
