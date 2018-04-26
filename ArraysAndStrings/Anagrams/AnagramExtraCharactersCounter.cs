using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Anagrams
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem
    /// 
    /// Alice is taking a cryptography class and finding anagrams to be very useful. 
    /// We consider two strings to be anagrams of each other if the first string's letters can be rearranged to form the second string. 
    /// In other words, both strings must contain the same exact letters in the same exact frequency. 
    /// For example, bacdc and dcbac are anagrams, but bacdc and dcbad are not.
    /// Alice decides on an encryption scheme involving two large strings where encryption is dependent on the minimum number of character 
    /// deletions required to make the two strings anagrams.Can you help her find this number?
    /// Given two strings, and , that may or may not be of the same length, determine the minimum number of character deletions required to make  and anagrams.
    /// Any characters can be deleted from either of the strings.
    /// </summary>
    public class AnagramExtraCharactersCounter
    {
        public static int GetNumberOfCharactersToRemove(string aStr, string bStr)
        {
            if (aStr == null)
                throw new ArgumentNullException(nameof(aStr));

            if (bStr == null)
                throw new ArgumentNullException(nameof(bStr));

            if (aStr.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(aStr));

            if (bStr.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(bStr));

            var result = 0;
            var dic = new Dictionary<char, int>();
            foreach (var aChar in aStr)
            {
                if (dic.ContainsKey(aChar))
                    dic[aChar]++;
                else
                    dic[aChar] = 1;
            }

            foreach (var bChar in bStr)
            {
                if (dic.ContainsKey(bChar))
                    dic[bChar]--;
                else
                    dic[bChar] = -1;
            }

            foreach (var c in dic)
            {
                result += Math.Abs(dic[c.Key]);
            }
            return result;
        }
    }
}
