using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DynamicProgramming
{
    public static class LongestCommonSubsequence
    {
        public static string GetLongestCommonSubsequence(string aStr, string bStr)
        {
            var result = new List<char>();
            var a = aStr.ToCharArray();
            var b = bStr.ToCharArray();
            var lcsLength = GetLCSLength(a, b);
            PrintLCSTable(lcsLength, a, b);
            Backtrack(result, lcsLength, a, b, a.Length - 1, b.Length - 1);
            return new String(result.ToArray());
        }

        private static void PrintLCSTable(int[,] lcsTable, char[] a, char[] b)
        {
            Trace.Write($" ");
            for (int j = 0; j < lcsTable.GetLength(1); j++)
            {
                Trace.Write($" {b[j]}");
            }

            Trace.WriteLine(String.Empty);
            for (int i = 0; i < lcsTable.GetLength(0); i++)
            {
                Trace.Write($"{a[i]} ");
                for (int j = 0; j < lcsTable.GetLength(1); j++)
                {
                    Trace.Write($"{lcsTable[i ,j]} ");
                }
                Trace.WriteLine(String.Empty);
            }
        }

        public static IEnumerable<string> GetLongestCommonSubsequences(string aStr, string bStr)
        {
            var result = new List<char>();
            var a = aStr.ToCharArray();
            var b = bStr.ToCharArray();
            var lcsLength = GetLCSLength(a, b);
            return GetAllBacktrack(result, lcsLength, a, b, a.Length - 1, b.Length - 1);            
        }

        private static int[,] GetLCSLength(char[] a, char[] b)
        {
            var result = new int[a.Length, b.Length];
            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        result[i, j] = (i == 0 || j == 0) ? 1 : result[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        result[i, j] = Math.Max(j == 0 ? 0 : result[i, j - 1], i == 0 ? 0 : result[i - 1, j]);
                    }                        
                }
            }
            return result;
        }

        private static void Backtrack(List<char> result, int[,] lcsLength, char[] a, char[] b, int i, int j)
        {
            if (i < 0 || j < 0)
                return;

            if (a[i] == b[j])
            {
                Backtrack(result, lcsLength, a, b, i - 1, j - 1);
                result.Add(a[i]);
            }
            else if (lcsLength[i - 1, j] >= lcsLength[i, j - 1])
            {
                Backtrack(result, lcsLength, a, b, i - 1, j);
            }
            else
            {
                Backtrack(result, lcsLength, a, b, i, j - 1);
            }
        }

        private static IEnumerable<string> GetAllBacktrack(List<char> result, int[,] lcsLength, char[] a, char[] b, int i, int j)
        {
            if (i < 0 || j < 0)
                yield return new String(result.ToArray());

            if (a[i] == b[j])
            {
                GetAllBacktrack(result, lcsLength, a, b, i - 1, j - 1);
                result.Add(a[i]);
            }
            else if (lcsLength[i - 1, j] >= lcsLength[i, j - 1])
            {
                GetAllBacktrack(result, lcsLength, a, b, i - 1, j);
            }
            else
            {
                GetAllBacktrack(result, lcsLength, a, b, i, j - 1);
            }
        }

    }
}
