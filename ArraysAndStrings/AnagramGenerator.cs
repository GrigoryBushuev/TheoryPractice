using System;
using System.Collections.Generic;
using System.Linq;
using ArraysAndStrings;

public class AnagramGenerator{
    public static IEnumerable<string> Generate(string source){     
        if (source == null)
            throw new ArgumentNullException(nameof(source));   

        var result = new LinkedList<string>();    
        Permutate(source.ToCharArray(), 0, source.Length, result);
        return result.Distinct();
    }
    private static void Permutate(char[] source, int start, int end, LinkedList<string> result){
        if (start > end)
            result.AddLast(new String(source));

        for (var i = start; i < end; i++){            
            source.Swap(start, i, out char[] swappedArray);                
            result.AddLast(new String(swappedArray));
            Permutate(swappedArray, start + 1, end, result);
        }
    }
}