using System;
using Xunit;

namespace ArraysAndStrings.Tests
{
    public class UniqueCheckerTest
    {
        [Theory]
        [InlineData("Qwerty", true)]
        [InlineData("TestTest", false)]
        public void HasAllCharactersUniqueTest(string testString, bool expectedResult)
        {
            //Act
            var result = UniqueChecker.HasAllCharactersUnique(testString);
            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData("Qwerty", true)]
        [InlineData("TestTest", false)]
        public void HasAllCharactersUniqueInplaceTest(string testString, bool expectedResult)
        {
            //Act
            var result = UniqueChecker.HasAllCharactersUniqueInplace(testString);
            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}
