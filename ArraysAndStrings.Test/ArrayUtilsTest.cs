using NUnit.Framework;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class ArrayUtilsTest
    {
        [Test]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void GetFactorialOfTest(int param, int expectedResult){
            //Act
            var actualResult = ArrayUtils.GetFactorialOf(param);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void FactorialTest(int param, int expectedResult)
        {
            //Act
            var actualResult = ArrayUtils.Factorial(param);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}