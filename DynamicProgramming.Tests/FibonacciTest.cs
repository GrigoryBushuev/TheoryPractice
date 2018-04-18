using NUnit.Framework;

namespace DynamicProgramming.Tests
{
    [TestFixture]
    public class FibonacciTest
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 5)]
        [TestCase(5, 8)]
        [TestCase(6, 13)]
        [TestCase(7, 21)]
        [TestCase(8, 34)]
        [TestCase(9, 55)]
        public void GetNth_OnValidParam_ReturnsExpextedValue(int n, int expectedValue)
        {
            //Act
            var actualResult = Fibonacci.GetNth(n);
            //Assert
            Assert.AreEqual(expectedValue, actualResult);
        }

        [TestCase(0, new int[]{ 1 })]
        [TestCase(1, new int[] { 1, 1 })]
        [TestCase(2, new int[] { 1, 1, 2 })]
        [TestCase(9, new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 })]
        public void GetFibonacciSequence_OnValidParam_ReturnsExpextedValue(int n, int[] expectedValue)
        {
            //Act
            var actualResult = Fibonacci.GetFibonacciSequence(n);
            //Assert
            Assert.AreEqual(expectedValue, actualResult);
        }
    }
}
