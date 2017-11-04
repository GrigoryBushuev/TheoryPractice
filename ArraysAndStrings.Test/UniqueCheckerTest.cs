using NUnit.Framework;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class UniqueCheckerTest
    {
        [Test]
        [TestCase("Qwerty", true)]
        [TestCase("TestTest", false)]
        public void HasAllCharactersUniqueTest(string testString, bool expectedResult)
        {
            //Act
            var result = UniqueChecker.HasAllCharactersUnique(testString);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        [TestCase("Qwerty", true)]
        [TestCase("TestTest", false)]
        public void HasAllCharactersUniqueInplaceTest(string testString, bool expectedResult)
        {
            //Act
            var result = UniqueChecker.HasAllCharactersUniqueInplace(testString);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
