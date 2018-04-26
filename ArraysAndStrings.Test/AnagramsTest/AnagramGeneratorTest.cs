using System.Linq;
using ArraysAndStrings.Anagrams;
using NUnit.Framework;

namespace ArraysAndStrings.Test.AnagramsTest
{
    [TestFixture]
    public class AnagramGeneratorTest{

        [TestCase("ABC", 6)]
        [TestCase("ABCD", 24)]
        public void Generates_OnTestString_ReturnsExpectedNumberOfPermutations(string testString, int expectedNumberOfPermutations)
        {    
             //Act
            var result = AnagramGenerator.Generate(testString);
             //Assert
            Assert.AreEqual(expectedNumberOfPermutations, result.Count());
        }
    }
}