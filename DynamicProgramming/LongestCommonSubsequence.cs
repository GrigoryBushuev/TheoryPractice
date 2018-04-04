using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public static class LongestCommonSubsequence
    {
        public static string GetLongestCommonSubstring(string aStr, string bStr)
        {
            var result = new List<char>();
            var a = aStr.ToCharArray();
            var b = bStr.ToCharArray();
            var lcsLength = GetLCSLength(a, b);
            BackTrack(result, lcsLength, a, b, a.Length - 1, b.Length - 1);
            return new String(result.ToArray());
        }

        private static int[,] GetLCSLength(char[] a, char[] b)
        {
            var result = new int[a.Length, b.Length];
            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                        result[i, j] = (i == 0 || j == 0) ? 1 : result[i - 1, j - 1] + 1;
                    else
                        result[i, j] = Math.Max(j == 0 ? 0 : result[i, j - 1], i == 0 ? 0 : result[i - 1, j]);
                }
            }
            return result;
        }

        private static void BackTrack(List<char> result, int[,] lcsLength, char[] a, char[] b, int i, int j)
        {
            if (i < 0 || j < 0)
                return;

            if (a[i] == b[j])
            {
                BackTrack(result, lcsLength, a, b, i - 1, j - 1);
                result.Add(a[i]);
            }
            else if (lcsLength[i - 1, j] >= lcsLength[i, j - 1])
            {
                BackTrack(result, lcsLength, a, b, i - 1, j);
            }
            else
            {
                BackTrack(result, lcsLength, a, b, i, j - 1);
            }
        }

    }
}
