using System;
using Xunit;

namespace ArraysAndStrings.Tests
{
    public class ArrayUtilsTest
    {
        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        public void GetFactorialOfTest(int param, int expectedResult){
            //Act
            var actualResult = ArrayUtils.GetFactorialOf(param);
            //Assert
            Assert.Equal(actualResult, expectedResult);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        public void FactorialTest(int param, int expectedResult)
        {
            //Act
            var actualResult = ArrayUtils.Factorial(param);
            //Assert
            Assert.Equal(actualResult, expectedResult);
        }
    }
}