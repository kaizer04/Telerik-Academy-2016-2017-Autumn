namespace Feathers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double birds = double.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());
            double averageFeathersPerBird = feathers / birds;
            double result;
            // Console.WriteLine(averageFeathersPerBird);
            if (birds % 2 == 0)
            {
                result = averageFeathersPerBird * 123123123123;
            }
            else
            {
                result = averageFeathersPerBird / 317;
            }

            Console.WriteLine("{0:0.0000}", result);
        }
    }
}
