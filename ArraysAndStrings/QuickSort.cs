using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndStrings
{
    public static class QuickSort<T> where T : IComparable<T>
    {
        private static int Partition(T[] dataToSort, int loIndex, int hiIndex){
            var partitionValue = dataToSort[loIndex];
            
            var i = loIndex + 1;
            var j = hiIndex;

            while(true){
                while(i < j && dataToSort[i].CompareTo(partitionValue) <= 0) i++;
                while(j > i && dataToSort[j].CompareTo(partitionValue) > 0) j--;
                if (i >= j) break;
                ArrayUtils.Swap(dataToSort, i, j);            
            }

            ArrayUtils.Swap(dataToSort, loIndex, j);
            return j;
        }

        public static void Sort(T[] dataToSort, int loIndex, int hiIndex){
            if (loIndex >= hiIndex)
                return;
            
            var partitionIndex = Partition(dataToSort, loIndex, hiIndex);  
            //After the partitioning an element at the partition index is located in the sorted position          
            Sort(dataToSort, loIndex, partitionIndex - 1);
            Sort(dataToSort, partitionIndex + 1, hiIndex);                
        }
    }

    public static class SortUtils
    {
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> dataToSort) where T : IComparable<T>{
            if (dataToSort==null)
                throw new ArgumentNullException(nameof(dataToSort));

            if (dataToSort.Count() == 1)
                return dataToSort;

            var sortedArray = dataToSort.ToArray();
            QuickSort<T>.Sort(sortedArray, 0, dataToSort.Count() - 1);
            return sortedArray;        
        }
    } 
}