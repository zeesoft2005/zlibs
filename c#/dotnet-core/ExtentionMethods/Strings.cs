using System;

namespace ExtentionMethods
{
    public static class Strings
    {
        /// <summary>
        /// Truncates a string
        /// </summary>
        /// <param name="value">string input</param>
        /// <param name="maxChars">limit of max characters to show as string</param>
        /// <param name="trailingChar">character used to show missing/trucated characters; default: '.'</param>
        /// <param name="repeatCount">no of times the trailingCharacter is to be shown; default: 3</param>
        /// <returns></returns>
        public static string Truncate(this string value, int maxChars, char trailingChar = '.', int repeatCount = 3)
        {
            if (string.IsNullOrEmpty(value))
                return "";
            var trailingStr = new string(trailingChar, repeatCount);
            return value.Length <= maxChars ? value : value.Substring(0, maxChars) + trailingStr;
        }
    }
}
