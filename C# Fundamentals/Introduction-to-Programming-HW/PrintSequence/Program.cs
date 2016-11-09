namespace PrintSequence
{
    using System;

    public class PrintTheFirst10MembersOfTheSequence
    {
        public static void Main()
        {
            //int i = 1;
            for (int j = 2; j < 12; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.WriteLine(j * (-1));
                }
            }
        }
    }
}
