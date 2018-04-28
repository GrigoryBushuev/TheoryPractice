using NUnit.Framework;

namespace BitwiseOperations.Test
{
    [Category("Bitwise")]
    [TestFixture]
    public class BitwiseUtilsTest
    {
        [TestCase(0, 1)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        public void SwapTest(int a, int b)
        {
            //Arrange
            var expectedResultB = a;
            var expectedResultA = b;
            //Act
            BitwiseUtils.Swap(ref a, ref b);
            Assert.AreEqual(a, expectedResultA);
            Assert.AreEqual(b, expectedResultB);
        }

        [TestCase(8, "1000")]
        [TestCase(7, "111")]
        [TestCase(6, "110")]
        public void DecToBinary_OnValidParams_ReturnsExpectedResult(int dec, string expectedResult)
        {
            //Act
            var actualResult = BitwiseUtils.DecToBinary(dec);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
