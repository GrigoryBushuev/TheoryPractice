using NUnit.Framework;

namespace BitwiseOperations.Test
{
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

    }
}
