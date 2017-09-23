using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{  
    public static class ArrayUtils
    {
        public static long Factorial(int n){
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            long Fact(int val)
            {
                if (val == 0)
                    return 1;
                return val * Fact(val - 1);
            }

            return Fact(n);        
        }        

        public static long GetFactorialOf(int n){
            long result = 1;
            for (int i = 2; i <= n; i++){
                result = result * i;
            }
            return result;
        }

        public static void Swap<T>(this T[] array, int i, int j, out T[] result){
            if (array == null)
                throw new NullReferenceException(nameof(array));

            result = array.Clone() as T[];
            if (i == j)
                return;

            var temp = result[j];
            result[j] = result[i];
            result[i] = temp;            
        }

        public static void Swap<T>(T[] array, int i, int j){
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (i == j)
                return;

            var temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }    
    }
}