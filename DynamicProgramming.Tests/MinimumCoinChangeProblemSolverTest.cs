using NUnit.Framework;

namespace DynamicProgramming.Tests
{
    [TestFixture]
    public class MinimumCoinChangeProblemSolverTest
    {
        [TestCase(new int[] { 1, 5, 10, 25}, 49, 7)]
        [TestCase(new int[] { 1, 5, 10, 25 }, 6, 2)]
        [TestCase(new int[] { 1, 5, 10, 25 }, 1, 1)]
        [TestCase(new int[] { 10, 6, 1}, 12, 2)]
        public void GetMinNumberOfCoinsToChange_OnValidParams_ReturnsExpectedResult(int[] coins, int amount, int expectedResult)
        {
            //Arrange
            //Act
            var actualResult = MinimumCoinChangeProblemSolver.GetMinNumberOfCoinsToChange(amount, coins);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
