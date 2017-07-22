using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    public class Program
    {
        public static void Main()
        {
            int cNumberOfSongs = int.Parse(Console.ReadLine());

            string[] volumesString = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] volumesIntegers = new int[volumesString.Length];
            for (int i = 0; i < volumesString.LongLength; i++)
            {
                volumesIntegers[i] = int.Parse(volumesString[i]);
            }

            int bStart = int.Parse(Console.ReadLine());

            int mMax = int.Parse(Console.ReadLine());

            int[,] dpMatrix = new int[cNumberOfSongs + 1, mMax + 1];

            dpMatrix[0, bStart] = 1;
            for (int currentVolumeChange = 1; currentVolumeChange <= cNumberOfSongs; currentVolumeChange++)
            {
                for (int possibleVolume = 0; possibleVolume <= mMax; possibleVolume++)
                {
                    if (dpMatrix[currentVolumeChange - 1, possibleVolume] == 1)
                    {
                        int newPossibleVolume = possibleVolume - volumesIntegers[currentVolumeChange - 1];
                        if (newPossibleVolume >= 0)
                        {
                            dpMatrix[currentVolumeChange, newPossibleVolume] = 1;
                        }

                        newPossibleVolume = possibleVolume + volumesIntegers[currentVolumeChange - 1];
                        if (newPossibleVolume <= mMax)
                        {
                            dpMatrix[currentVolumeChange, newPossibleVolume] = 1;
                        }
                    }
                }
            }

            for (int i = mMax; i >= 0; i++)
            {
                if (dpMatrix[cNumberOfSongs, i] == 1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}