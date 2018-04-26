using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Anagrams
{
    public static class AnagramChecker
    {
        private static IDictionary<char, int> GetStringInfo(string testString)
        {
            var testDictionary = new Dictionary<char, int>();
            foreach (var letter in testString)
            {
                if (testDictionary.ContainsKey(letter))
                    testDictionary[letter]++;
                else
                    testDictionary.Add(letter, 0);
            }
            return testDictionary;
        }


        public static bool IsAnagram(string first, string second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            var firstInfo = GetStringInfo(first);
            var secondInfo = GetStringInfo(second);

            foreach (var firstInfoKV in firstInfo)
            {
                if (!secondInfo.ContainsKey(firstInfoKV.Key) || secondInfo[firstInfoKV.Key] != firstInfoKV.Value)
                    return false;
            }
            return true;
        }

    }
}
