using ArraysAndStrings.Anagrams;
using NUnit.Framework;

namespace ArraysAndStrings.Test.AnagramsTest
{
    [TestFixture]
    public class AnagramCheckerTest
    {
        [TestCase("AABCD", "BACAD", true)]
        [TestCase("ABCD", "BACAD", false)]
        public void IsAnagramTest(string first, string second, bool expectedResult)
        {
            //Act
            var actualResult = AnagramChecker.IsAnagram(first, second);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
