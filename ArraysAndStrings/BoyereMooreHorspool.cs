using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings
{
    public static class BoyereMooreHorspool
    {
        private static IDictionary<char, int> GetBadMatches(string pattern)
        {
            var badMatches = new Dictionary<char, int>();
            var patternLength = pattern.Length;
            for (var i = 0; i < patternLength; i++)
            {
                badMatches[pattern[i]] = patternLength - i - 1;
            }
            return badMatches;
        }

        public static IEnumerable<int> GetMatches(string toSearch, string toFind)
        {
            if (string.IsNullOrEmpty(toSearch))
                throw new ArgumentOutOfRangeException(nameof(toSearch));

            if (string.IsNullOrEmpty(toFind))
                throw new ArgumentOutOfRangeException(nameof(toFind));

            var badMatches = GetBadMatches(toFind);
            var toFindLength = toFind.Length;
            for (var i = toFindLength; i < toSearch.Length; i++)
            {
                var currentChar = toSearch[i];
                if (!badMatches.ContainsKey(currentChar))
                {
                    i += toFindLength - 1;
                }
                else
                {
                    i += badMatches[currentChar];
                    var j = i;
                    var findIndex = toFindLength - 1;
                    while (findIndex > 0 && String.Equals(toSearch[j], toFind[findIndex]))
                    {
                        j--;
                        findIndex--;
                    }
                    if (findIndex == 0)
                        yield return j;
                }
            }
        }
    }
}
