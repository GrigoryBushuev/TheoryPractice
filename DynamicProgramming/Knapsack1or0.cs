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
        public static decimal GetKnapsackItems(decimal maxWeight, List<KnapsackItem> items)
        {
            return GetKnapsackItems(0, maxWeight, items);
        }

        private static decimal GetKnapsackItems(int index, decimal maxWeight, List<KnapsackItem> items)
        {
            if (index == items.Count())
                return 0;

            if (items[index].Weight > maxWeight)
                return GetKnapsackItems(index + 1, maxWeight, items);

            return Math.Max(GetKnapsackItems(index + 1, maxWeight, items)
                                , GetKnapsackItems(index + 1, maxWeight - items[index].Weight, items) + items[index].Value);
        }
    }
}
