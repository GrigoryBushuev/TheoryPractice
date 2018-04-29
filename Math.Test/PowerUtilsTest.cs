using NUnit.Framework;

namespace MathUtils.Test
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

        [TestCase(1u, true)]
        [TestCase(2u, true)]
        [TestCase(4u, true)]
        [TestCase(6u, false)]
        [TestCase(7u, false)]
        [TestCase(8u, true)]
        [TestCase(16u, true)]
        [TestCase(24u, false)]
        [TestCase(31u, false)]
        [TestCase(32u, true)]
        [TestCase(64u, true)]
        [TestCase(128u, true)]
        [TestCase(256u, true)]
        [TestCase(512u, true)]
        [TestCase(1024u, true)]
        public void IsPowerOf2_ReturnsExpectedResult(uint p, bool expectedResult)
        {
            var actualResult = PowerUtils.IsPowerOf2(p);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
