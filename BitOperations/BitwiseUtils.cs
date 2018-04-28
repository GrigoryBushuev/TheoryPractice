using System.Text;
using System.Linq;
using System;

namespace BitwiseOperations
{
    public static class BitwiseUtils
    {
        /// <summary>
        /// Swap two numbers without using a temporary variable
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            b = a ^ b;
            a = a ^ b;
            b = a ^ b;
        }

        /// <summary>
        /// Converts an integer to binary
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static string DecToBinary(int dec)
        {
            var sb = new StringBuilder();
            while (dec != 0) {
                sb.Append(dec % 2);
                dec = dec / 2;                
            }

            return new String(sb.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
