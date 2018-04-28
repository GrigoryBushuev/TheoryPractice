using NUnit.Framework;

namespace Backtracking.Tests
{
    [Category("KnightsTour")]
    [TestFixture]
    public class KnightsTourTest
    {
        [Test]
        public void SolveTest()
        {
            //Arrange
            var knightsTour = new KnightsTour();
            //Act
            var result = knightsTour.Solve(0, 0);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
