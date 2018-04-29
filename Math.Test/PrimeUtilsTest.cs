using NUnit.Framework;

namespace MathUtils.Tests
{
    [Category("PrimeUtils")]
    [TestFixture]
    public class PrimeUtilsTest
    {
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        public void IsPrime_OnValidParams_ReturnsExpectedResult(int n, bool expectedResult)
        {
            //Act
            var actualResult = n.IsPrime();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);        
        }
    }
}
