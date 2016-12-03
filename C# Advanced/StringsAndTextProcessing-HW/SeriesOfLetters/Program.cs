    namespace SeriesOfLetters
    {
        using System;
        using System.Text;

        public class Program
        {
            public static void Main()
            {
                string text = Console.ReadLine();

                StringBuilder answer = new StringBuilder();
                answer.Append(text[0]);

                for (int i = 1; i < text.Length; i++)
                {
                    if (text[i] != text[i - 1])
                    {
                        answer.Append(text[i]);
                    }
                }

                Console.WriteLine(answer.ToString());
            }
        }
    }
