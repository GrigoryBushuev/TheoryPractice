using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    public struct KnapsackItem
    {
        public decimal Weight { get; set; }
        public decimal Value { get; set; }
    }

    /// <summary>
    /// Given a list of items with values and weights, as well as a max
    /// weight, find the maximum value you can generate from items,
    /// where the sum of the weights is less than or equal to the max.
    /// </summary>
    public static class Knapsack1or0
    {
        /// <summary>
        /// For each item we add it to knapsack
        /// or we skip current item
        /// and calculate the total value of knapsack with and without the item
        /// if we reach a maximum weight we skip the item
        ///Eventually take max value of the knapsack
        /// </summary>
        /// <param name="maxWeight"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static decimal GetMaxValue(decimal maxWeight, List<KnapsackItem> items)
        {
            var cache = new Dictionary<KeyValuePair<int, decimal>, decimal?>();
            return GetMaxValue(cache, 0, maxWeight, items);
        }

        private static decimal GetMaxValue(Dictionary<KeyValuePair<int, decimal>, decimal?> cache, int index, decimal maxWeight, List<KnapsackItem> items)
        {
            if (index == items.Count())
                return 0;

            var cacheKey = new KeyValuePair<int, decimal>(index, maxWeight);
            if (cache.ContainsKey(cacheKey))
                return cache[cacheKey].Value;

            decimal? result;
            if (items[index].Weight > maxWeight)
                result = GetMaxValue(cache, index + 1, maxWeight, items);
            else
                result = Math.Max(GetMaxValue(cache, index + 1, maxWeight, items)
                                , GetMaxValue(cache, index + 1, maxWeight - items[index].Weight, items) + items[index].Value);

            cache[cacheKey] = result;
            return cache[cacheKey].Value;
        }

        public static IList<KnapsackItem> GetKnapsackItems(decimal maxWeight, List<KnapsackItem> items)
        {
            return GetKnapsackItems(0, maxWeight, items);
        }

        private static IList<KnapsackItem> GetKnapsackItems(int index, decimal maxWeight, IList<KnapsackItem> items)
        {
            var result = new List<KnapsackItem>();
            if (index == items.Count())
                return result;

            if (items[index].Weight > maxWeight){
                result.AddRange(GetKnapsackItems(index + 1, maxWeight, items));
                return result;
            }
            var currentItem = items[index];
            var includedItems = GetKnapsackItems(index + 1, maxWeight - currentItem.Weight, items);
            var excludedItems = GetKnapsackItems(index + 1, maxWeight, items);
            if (includedItems.Sum(i => i.Value) + currentItem.Value > excludedItems.Sum(i => i.Value)) {
                result.AddRange(includedItems);
                result.Add(currentItem);
            }
            else {
                result.AddRange(excludedItems);
            }
            return result;
        }
    }
}
