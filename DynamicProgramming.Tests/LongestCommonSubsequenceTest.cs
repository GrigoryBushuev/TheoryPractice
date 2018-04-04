using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Tests
{
    [TestFixture]
    public class LongestCommonSubsequenceTest
    {
        [TestCase("XMJYAUZ", "MZJAWXU", "MJAU")]
        [TestCase("ABCBDAB", "BDCABA", "BCBA")]
        public void GetLongestCommonSubstring_OnValidParams_ReturnsExpectedResult(string aStr, string bStr, string expectedResult)
        {            
            //Act
            var actualResult = LongestCommonSubsequence.GetLongestCommonSubstring(aStr, bStr);
            //Assert
            Assert.IsInstanceOf<string>(actualResult);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
