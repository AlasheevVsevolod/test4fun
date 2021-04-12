using System;
using System.Linq;

namespace test4fun
{
    public static class StringExtensions
    {
        public static string Collapse(this string text)
        {
            var charsToTake = 5;
            var finisher = "...";

            return $"{new string(text.Take(charsToTake).ToArray())}{finisher}";
        }
    }
}
