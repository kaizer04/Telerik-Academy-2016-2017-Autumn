namespace StringLength
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            // Console.WriteLine("If the length of the string is less than 20, the rest of the characters should be filled with '*'");
            // Console.Write("Enter string: ");
            string s = Console.ReadLine();
            //string subS = "";
            StringBuilder fillS = new StringBuilder(s);
            for (int i = s.Length; i <= 19; i++)
            {
                fillS.Append('*');
            }

            Console.WriteLine(fillS);
        }
    }
}
