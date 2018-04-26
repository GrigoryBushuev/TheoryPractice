using ArraysAndStrings.Anagrams;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndStrings.Test.AnagramsTest
{
    [TestFixture]
    public class AnagramExtraCharactersCounterTest
    {
        [TestCase("cde", "abc", 4)]
        [TestCase("cde", "abbc", 5)]
        public void GetNumberOfCharactersToRemove_OnValidParams_ReturnsExpectedResult(string strA, string strB, int expectedResult)
        {
            var actualResult = AnagramExtraCharactersCounter.GetNumberOfCharactersToRemove(strA, strB);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(null, "non empty")]
        public void GetNumberOfCharactersToRemove_OnFirstNullParam_ThrowsArgumentNullException(string aStr, string bStr)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => AnagramExtraCharactersCounter.GetNumberOfCharactersToRemove(aStr, bStr));
            Assert.AreEqual(ex.ParamName, nameof(aStr));
        }

        [TestCase("non empty", null)]
        public void GetNumberOfCharactersToRemove_OnSecondNullParam_ThrowsArgumentNullException(string aStr, string bStr)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => AnagramExtraCharactersCounter.GetNumberOfCharactersToRemove(aStr, bStr));
            Assert.AreEqual(ex.ParamName, nameof(bStr));
        }

        [TestCase("", "non empty")]
        public void GetNumberOfCharactersToRemove_OnFirstemptyParam_ThrowsArgumentOutOfRangeException(string aStr, string bStr)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => AnagramExtraCharactersCounter.GetNumberOfCharactersToRemove(aStr, bStr));
            Assert.AreEqual(ex.ParamName, nameof(aStr));
        }

        [TestCase("non empty", "")]
        public void GetNumberOfCharactersToRemove_OnSecondEmptyParam_ThrowsArgumentOutOfRangeException(string aStr, string bStr)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => AnagramExtraCharactersCounter.GetNumberOfCharactersToRemove(aStr, bStr));
            Assert.AreEqual(ex.ParamName, nameof(bStr));
        }
    }
}
