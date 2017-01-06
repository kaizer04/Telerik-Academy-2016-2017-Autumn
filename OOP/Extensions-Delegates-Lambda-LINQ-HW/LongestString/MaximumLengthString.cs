using System;
using System.Linq;

namespace LongestString
{
    public class MaximumLengthString
    {
        public static void Main()
        {
            string[] array = new[] { "asd", "asdf", "theBigOne" };

            var sortedQuery = from str in array
                                  orderby str.Length
                                  select str;

            var longestString = sortedQuery.LastOrDefault();
            
            Console.WriteLine(longestString);
        }
    }
}
