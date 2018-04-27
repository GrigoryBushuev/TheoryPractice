using NUnit.Framework;

namespace Math.Test
{
    [TestFixture]
    public class PowerUtilsTest
    {
        [TestCase(2, 3u, 8)]
        [TestCase(3, 0u, 1)]
        [TestCase(0, 1u, 0)]
        [TestCase(0, 0u, 1)]
        public void PowerOfQ_ReturnsExpectedResult(int p, uint q, int expectedResult)
        {
            var actualResult = PowerUtils.PowerOfQ(p, q);
            Assert.AreEqual(actualResult, expectedResult);
        }

    }
}
