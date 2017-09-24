using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ArraysAndStrings.Test
{
    public class AnagramCheckerTest
    {
        [Theory]
        [InlineData("AABCD", "BACAD", true)]
        [InlineData("ABCD", "BACAD", false)]
        public void IsAnagramTest(string first, string second, bool expectedResult)
        {
            //Act
            var actualResult = AnagramChecker.IsAnagram(first, second);
            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
