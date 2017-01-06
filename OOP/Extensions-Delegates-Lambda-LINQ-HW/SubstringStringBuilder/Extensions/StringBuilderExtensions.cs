namespace SubstringStringBuilder
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            return new StringBuilder(input.ToString().Substring(index, length));
        }
    }
}