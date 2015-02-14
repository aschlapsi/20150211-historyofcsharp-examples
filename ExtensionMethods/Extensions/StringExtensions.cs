using System;

namespace ExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            var parts = str.Split(
                new [] {' ', '.', '?'},
                StringSplitOptions.RemoveEmptyEntries);

            return parts.Length;
        }
    }
}