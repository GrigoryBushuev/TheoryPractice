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

    //For each item in knapsack we add it to knapsack and calculate the total value of knapsack with the added item
    //or we skip current item  and calculate the total value of knapsack without the item
    //if we reach a maximum weight we have to skip the item
    public static class Knapsack1or0
    {
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
