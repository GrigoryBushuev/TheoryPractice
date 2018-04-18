using NUnit.Framework;
using System;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class StringUtilsTest
    {
        [TestCase("ABC", "CBA")]
        [TestCase("ABCD", "DCBA")]
        public void Reverse_OnValidParam_ReturnsExpectedResult(string param, string expectedResult)
        {
            //Act
            var actualResult = param.Reverse();
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        public void Reverse_OnEmptyParam_ThrowsArgumentNullException(string param, string expectedResult)
        {
            //Assert
            Assert.Catch<ArgumentNullException>(() => param.Reverse());
        }

    }
}
