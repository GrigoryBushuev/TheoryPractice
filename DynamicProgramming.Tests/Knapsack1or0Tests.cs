using DynamicProgramming;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming.Tests
{
    [TestFixture]
    public class Knapsack1or0Tests
    {

        static IEnumerable<object> KnapsackTestSource()
        {
            yield return new object[] { 5M, 22M, new KnapsackItem[] {
                                                                      new KnapsackItem(){ Weight = 2, Value = 6}
                                                                      , new KnapsackItem(){ Weight = 2, Value = 10 }
                                                                      , new KnapsackItem(){ Weight = 3, Value = 12 }
                                                                     }};

            yield return new object[] { 8.1M, 24.9M, new KnapsackItem[] {
                                                                        new KnapsackItem() { Value = 1.5M, Weight = 8M }
                                                                        , new KnapsackItem() { Value = 2.3M, Weight = 6M }
                                                                        , new KnapsackItem() { Value = 1.8M, Weight = 4M }
                                                                        , new KnapsackItem() { Value = 7.9M, Weight = 3M }
                                                                        , new KnapsackItem() { Value = 8M, Weight = 3M }
                                                                        , new KnapsackItem() { Value = 9M, Weight = 2M }
                                                                     }};
        }

        [TestCaseSource("KnapsackTestSource")]
        public void GetKnapsackItems_OnValidParams_ReturnsExpectedResult(decimal maxWeight, decimal expectedValue, IEnumerable<KnapsackItem> knapsackItems)
        {
            // Act
            var actualResult = Knapsack1or0.GetKnapsackItems(maxWeight, knapsackItems.ToList());
            // Assert
            Assert.AreEqual(expectedValue, actualResult);
        }
    }
}
