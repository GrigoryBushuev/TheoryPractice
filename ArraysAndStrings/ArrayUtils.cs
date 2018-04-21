using System;
using System.Collections.Generic;

namespace ArraysAndStrings
{  
    public static class ArrayUtils
    {
        /// <summary>
        /// Fisher-Yates shuffling
        /// </summary>
        /// <param name="array"></param>
        public static void Shuffle<T>(this T[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (array.Length == 0)
                return;

            var rand = new Random();
            for (var i = array.Length - 1; i >= 0; i--)
            {
                var j = rand.Next(i);
                Swap(array, j, i);
            }
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