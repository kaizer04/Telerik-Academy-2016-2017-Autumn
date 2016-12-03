//namespace ReplaceTags
//{
//    using System;
//    using System.Text;

//    public class Program
//    {
//        public static void Main()
//        {
//            string s = Console.ReadLine();
//            StringBuilder buildS = new StringBuilder(s);
//            //for (int i = 0; i < buildS.Length; i++)
//            //{
//            buildS = buildS.Replace("<a href=\"", "[URL=");
//            buildS = buildS.Replace("<a href=\"", "[URL=");
//            buildS = buildS.Replace("\">", "]");
//            buildS = buildS.Replace("</a>", "[/URL]");
//            //  }
//            Console.WriteLine(buildS);
//        }
//    }
//}


namespace ReplacingTags
{

    using System;
    using System.Text;

    class ReplacingHrefTags
    {
        static void Main()
        {
            // string originalText = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string originalText = Console.ReadLine();
            StringBuilder answer = new StringBuilder();

            string[] messages = originalText.Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None);
            //Console.WriteLine(string.Join("\n", messages));
            foreach (var item in messages)
            {
                int indexOfLink = item.IndexOf("=\"");

                if (indexOfLink >= 0)
                {
                    int endIndex = item.IndexOf("\">");
                    int startIndexText = endIndex + 2;
                    int endIndexText = item.Length;
                    answer.Append("[");
                    answer.Append(item.Substring(startIndexText, endIndexText - startIndexText));
                    answer.Append("]");
                    answer.Append("(");
                    answer.Append(item.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
                    answer.Append(")");
                }
                else
                {
                    answer.Append(item);
                }
            }


            if (answer.Length == 0)
            {
                Console.WriteLine(originalText);
            }
            else
            {
                Console.WriteLine(answer.ToString());
            }
        }
    }
}



//using System;
//using System.Text.RegularExpressions;


//    public class ReplaceTags
//{
//    public static void Main()
//    {
//        string text = Console.ReadLine();

//        Regex reg = new Regex(@"(<\s*a\s*href\s*=)\s*""(.*?)""\s*>(.*?)<\s*/\s*a\s*>");
//        string answer = reg.Replace(text, m => "[" + m.Groups[3] + "](" + m.Groups[2] + ")");

//        Console.WriteLine(answer);
//    }
//}

//    using System;

//class Program
//{
//    static void Main()
//    {
//        string input = Console.ReadLine();
//        string[] splitted = input.Split(new[] { "<a href=\"", "</a>" }, StringSplitOptions.None);
//        for (int i = 1; i < splitted.Length; i += 2)
//        {
//            int index = splitted[i].IndexOf("\">");
//            string URL = splitted[i].Substring(0, index);
//            string TEXT = splitted[i].Substring(index + 2, splitted[i].Length - index - 2);
//            splitted[i] = "[" + TEXT + "]" + "(" + URL + ")";
//        }
//        Console.WriteLine(string.Join(string.Empty, splitted));

//    }
//}
