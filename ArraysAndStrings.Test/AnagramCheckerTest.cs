using NUnit.Framework;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class AnagramCheckerTest
    {
        [Test]
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
