namespace HiddenMessage
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<char> outputMessage = new List<char>();

            while (true)
            {
                string isEnd = Console.ReadLine();
                if (isEnd == "end")
                {
                    break;
                }

                int startIndex = int.Parse(isEnd);
                int numberOfSymbolsToSkip = int.Parse(Console.ReadLine());
                string inputMessage = Console.ReadLine();
                if (startIndex < 0)
                {
                    startIndex = inputMessage.Length + startIndex;
                }

                if (numberOfSymbolsToSkip < 0)
                {
                    for (int i = startIndex; i >= 0; i = i + numberOfSymbolsToSkip)
                    {
                        outputMessage.Add(inputMessage[i]);
                    }
                }
                else
                {
                    for (int i = startIndex; i < inputMessage.Length; i = i + numberOfSymbolsToSkip)
                    {
                        outputMessage.Add(inputMessage[i]);
                    }
                }                
            }
            
            foreach (var item in outputMessage)
            {
                Console.Write(item);
            }
        }
    }
}
