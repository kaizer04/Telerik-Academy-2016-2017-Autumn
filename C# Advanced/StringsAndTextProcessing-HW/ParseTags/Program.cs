namespace ParseTags
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.");
            // Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            string subString = string.Empty;
            StringBuilder changedText = new StringBuilder(text);
            for (int i = 0; i < text.Length - 8; i++)
            {
                int findStartIndexUpcase = text.IndexOf("<upcase>", i);
                int findStartIndexSlashUpcase = text.IndexOf("</upcase>", i);
                if (findStartIndexUpcase == -1 || findStartIndexSlashUpcase == -1)
                {
                    break;
                }

                subString = text.Substring(findStartIndexUpcase + 8, findStartIndexSlashUpcase - (findStartIndexUpcase + 8));
                //Console.WriteLine(subS);
                changedText = changedText.Replace("<upcase>" + subString + "</upcase>", subString.ToUpper());
                i = findStartIndexSlashUpcase + 8;
            }

            // Console.WriteLine("The result:");
            Console.WriteLine(changedText);
        }
    }
}
