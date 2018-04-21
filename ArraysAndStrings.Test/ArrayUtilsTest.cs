using NUnit.Framework;
using System;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class ArrayUtilsTest
    {
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void GetFactorialOfTest(int param, int expectedResult){
            //Act
            var actualResult = Factorial.GetFactorialOf(param);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(3, 6)]
        [TestCase(4, 24)]
        public void FactorialTest(int param, int expectedResult)
        {
            //Act
            var actualResult = Factorial.GetFactorial(param);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }


        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9})]
        public void ShuffleTest(int[] array) {
            var initialArray = array.Clone() as int[];
            //Act
            array.Shuffle();
            //Assert
            CollectionAssert.AreEquivalent(initialArray, array);
            CollectionAssert.AreNotEqual(initialArray, array);
        }

        [Test]
        public void Shuffle_OnEmptyArray_ThrowsArgumentNullexception()
        {
            //Arrange
            int[] array = null;
            //Act
            //Assert
            Assert.Throws<ArgumentNullException>(() => array.Shuffle());
        }
    }
}