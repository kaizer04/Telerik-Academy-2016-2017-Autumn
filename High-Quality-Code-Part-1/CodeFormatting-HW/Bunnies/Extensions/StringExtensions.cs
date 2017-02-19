﻿namespace Bunnies.Extensions
{
    using System;
    using System.Text;

    public static class StringExtensions
    {
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            var probableStringMargin = 10;
            var probableStringSize = sequence.Length + probableStringMargin;

            var builder = new StringBuilder(probableStringSize);

            char singleWhitespace = ' ';

            foreach (var letter in sequence)
            {
                if (Char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
