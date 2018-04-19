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
