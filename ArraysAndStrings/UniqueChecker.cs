using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndStrings
{
    public class UniqueChecker
    {        
        public static bool HasAllCharactersUniqueInplace(string stringToCheck){
            if (stringToCheck == null)
                throw new ArgumentNullException(nameof(stringToCheck));

            if (stringToCheck.Length == 0)
                return true;//TODO: Need to discuss 

            var sortedArr = stringToCheck.ToCharArray().Sort().ToArray();
            for(var i = 1; i < sortedArr.Count(); i++){
                if (sortedArr[i] == sortedArr[i - 1])
                return false;
            }
            return true;        
        }

        public static bool HasAllCharactersUnique(string stringToCheck){
            if (stringToCheck == null)
                throw new ArgumentNullException(nameof(stringToCheck));

            if (stringToCheck.Length == 0)
                return true;//TODO: Need to discuss 

            var set = new HashSet<char>();
            foreach (var symbol in stringToCheck)
            {
                if (set.Contains(symbol))
                    return false;

                set.Add(symbol);                            
            }
            return true;
        }
    }
}