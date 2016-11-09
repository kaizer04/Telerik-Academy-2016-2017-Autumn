namespace PrintDeck
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] signsOfDeck = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string inputCard = Console.ReadLine();
            int i = -1;
            do
            {
                i++;
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", signsOfDeck[i]);
            } while (signsOfDeck[i] != inputCard);
            //int n = Array.IndexOf(signsOfDeck, inputCard);
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", signsOfDeck[i]);
            //}
        }
    }
}
