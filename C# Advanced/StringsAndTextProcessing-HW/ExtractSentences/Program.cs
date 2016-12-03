//namespace ExtractSentences
//{
//    using System;

//    public class Program
//    {
//        public static void Main()
//        {
//            string sub = Console.ReadLine();
//            // Console.Write("Enter text: ");
//            string s = Console.ReadLine();

//            string[] sentences = s.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

//            foreach (string sentence in sentences)
//            {
//                string checkingSentence = sentence.ToLower();
//                int index = checkingSentence.IndexOf(" " + sub.ToLower() + " ");
//                int indexWithPoint = checkingSentence.IndexOf(sub.ToLower() + ".");
//                if (index > -1 || indexWithPoint > -1)
//                {
//                    Console.Write(sentence.Trim());
//                    Console.Write(". ");
//                }
//            }
//        }
//    }
//}
//Write a program that extracts from a given text all sentences containing given word.


//class ExtractSentences
//{
//    static void Main()
//    {
//        string keyWord = Console.ReadLine();

//                   string text = Console.ReadLine();



//        string[] splitted = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

//        foreach (var sent in splitted)
//        {
//            //I came up with a easier way to solve it, but the other comment solution works too.

//            string[] words = sent.Split(new char[] { ',', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

//            for (int i = 0; i < words.Length; i++)
//            {
//                if (keyWord == words[i])
//                {
//                    Console.Write(sent.Trim() + ". ");
//                }
//            }


//            //int index = sent.IndexOf(keyWord);

//            //while (index >= 0)
//            //{
//            //    //Here I check if the word is in the begging, end or middle of the sentence.
//            //    if ((sent[index - 1] == ' ' && sent[index + keyWord.Length] == ' ')
//            //        || (index == 0 && sent[index + keyWord.Length] == ' ')
//            //        || (sent[index - 1] == ' ' && (index + keyWord.Length) == sent.Length))
//            //    {
//            //        Console.Write(sent.Trim() + ". ");
//            //    }
//            //    index++;
//            //    index = sent.IndexOf(keyWord, index);
//            //}
//        }
//    }
//}

using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();

        string text = Console.ReadLine();
        string[] sentence = text.Split('.');

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i].Contains(" " + word + " ") || sentence[i].Contains(word.First().ToString().ToUpper() + String.Join("", word.Skip(1)) + " ") || sentence[i].Contains(" " + word))
            {
                Console.Write(sentence[i].Trim() + ". ");
            }
        }
        //Console.WriteLine(word.ToUpper());
    }

    //public static string FirstCharToUpper(string input)
    //{
    //    if (String.IsNullOrEmpty(input))
    //        throw new ArgumentException("ARGH!");
    //    return input.First().ToString().ToUpper() + input.Substring(1);
    //}
}