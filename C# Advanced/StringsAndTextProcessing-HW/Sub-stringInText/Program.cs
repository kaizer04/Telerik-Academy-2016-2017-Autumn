using System;

namespace Sub_stringInText
{
    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Finds how many times a substring is contained in a given text (perform case insensitive search)");
            // Console.Write("Enter substring to count: ");
            string pattern = Console.ReadLine();
            // Console.Write("Enter text: ");
            string text = Console.ReadLine();
            
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int find = text.ToLower().IndexOf(pattern.ToLower(), i);
                if (find != -1)
                {
                    count++;
                    i = find;
                }
            }

            Console.WriteLine(count);
            //Console.WriteLine(Regex.Matches(s, subS, RegexOptions.IgnoreCase).Count); //това е много тарикатско трбва ни using System.Text.RegularExpressions; и си спестяваме 10 реда заедно с for цикъла
        }
    }
}
