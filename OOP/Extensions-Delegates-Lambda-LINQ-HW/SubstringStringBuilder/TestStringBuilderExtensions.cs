namespace SubstringStringBuilder
{
    using System;
    using System.Text
        
    public class TestStringBuilderExtensions
    {
        public static void Main()
        {
            var s = new StringBuilder("Ivailo Yordanov");
            //s.Substring(08, 9);
            Console.WriteLine(s);

            var s1 = new StringBuilder();
            s1 = s.Substring(0, 6);
            Console.WriteLine(s1);

            var strBuild = new StringBuilder();
            strBuild.Append("Ivo Yordanov");
            Console.WriteLine(strBuild.Substring(0, 3));
        }
    }
}