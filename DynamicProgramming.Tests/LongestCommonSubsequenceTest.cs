using NUnit.Framework;

namespace DynamicProgramming.Tests
{
    [TestFixture]
    public class LongestCommonSubsequenceTest
    {
        //[TestCase("XMJYAUZ", "MZJAWXU", "MJAU")]
        [TestCase("ABCBDAB", "BDCABA", "BCBA")]
        public void GetLongestCommonSubstring_OnValidParams_ReturnsExpectedResult(string aStr, string bStr, string expectedResult)
        {            
            //Act
            var actualResult = LongestCommonSubsequence.GetLongestCommonSubsequence(aStr, bStr);
            //Assert
            Assert.IsInstanceOf<string>(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
