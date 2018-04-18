using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    public static class StringUtils
    {
        public static string Reverse(this string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            var sb = new StringBuilder(text);
            for (var i = 0; i < sb.Length / 2; i++) {
                var temp = sb[i];
                sb[i] = sb[sb.Length - 1 - i];
                sb[sb.Length - 1 - i] = temp;
            }
            return sb.ToString();
        }
    }
}
