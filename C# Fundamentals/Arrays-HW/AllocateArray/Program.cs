namespace AllocateArray
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write("arr[{0}] = ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            for (int i = 0; i < n; i++)
            {
                array[i] = 5 * i;
            }
            // Console.WriteLine("Array`s each element multiplied by 5:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
