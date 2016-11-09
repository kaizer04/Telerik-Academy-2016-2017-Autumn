namespace Busses
{
    using System;
    
    public class Program
    {
        public static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int[] busses = new int[s];
            for (int i = 0; i < s; i++)
            {
                busses[i] = int.Parse(Console.ReadLine());
            }

            int countBussGroups = 1;
            int lowerSpeedBus = busses[0];
            for (int i = 0; i < s - 1; i++)
            {
                if (busses[i + 1] <= lowerSpeedBus)
                {
                    countBussGroups++;
                    lowerSpeedBus = busses[i + 1];
                }
            }

            Console.WriteLine(countBussGroups);
        }
    }
}
