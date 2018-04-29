using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hashtables
{
    public class WordsCounter
    {
        private Dictionary<string, uint> _wordsCounter;

        public WordsCounter(string text)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            _wordsCounter = GetWordsCounter(text);
        }

        public uint GetWordsNumber(string word)
        {
            _wordsCounter.TryGetValue(GetNormalizedWord(word), out var result);
            return result;
        }

        private Dictionary<string, uint> GetWordsCounter(string text)
        {
            var dic = new Dictionary<string, uint>();
            foreach (var rawWord in text.Split(' '))
            {
                var normalizedWord = GetNormalizedWord(rawWord); 
                if (dic.ContainsKey(normalizedWord))
                    dic[normalizedWord]++;
                else
                    dic.Add(normalizedWord, 1);
            }
            return dic;
        }

        private string GetNormalizedWord(string word)
        {
            var result = word.ToUpper();
            if (Regex.IsMatch(result, ".*(;|,|:|\\?|\\.|!)$"))
                result = result.Substring(0, result.Length - 1);

            return result;
        }
    }
}
