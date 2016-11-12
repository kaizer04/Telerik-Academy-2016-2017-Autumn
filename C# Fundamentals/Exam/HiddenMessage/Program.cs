using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenMessage
{
    class Program
    {
        static void Main(string[] args)
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
            
            //outputMessage.Add('d');
            foreach (var item in outputMessage)
            {
                Console.Write(item);
            }

            //Console.WriteLine();
        }
    }
}
