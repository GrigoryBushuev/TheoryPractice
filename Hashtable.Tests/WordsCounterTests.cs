using Hashtables;
using NUnit.Framework;

namespace Hashtable.Tests
{
    [Category("WordsCounter")]
    [TestFixture]
    public class WordsCounterTests
    {
        private WordsCounter _wordsCounter = null;

        [SetUp]
        public void Setup()
        {
            _wordsCounter = new WordsCounter("Hello world! Count heLLo world. Hell of the world?");
        }

        [TestCase("NOSUCHWORD", 0u)]
        [TestCase("Hello", 2u)]
        [TestCase("world", 3u)]        
        public void GetWordsNumber_OnValidParam_ReturnsExpectedResult(string word, uint expectedResult)
        {
            //Act
            var actualResult = _wordsCounter.GetWordsNumber(word);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
