using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class BoyereMooreHorspoolTest
    {

#region General cases
        [Test]
        [TestCase("There is the truth in that sentence, the real truth", "truth", 13, 46)]
        public void BoyereMooreHorsPoool_OnPredefinedParameters_ReturnsExpectedIndexes(string toSearch, string toFind, params int[] expectedIndexes)
        {
            //Act
            var result = BoyereMooreHorspool.GetMatches(toSearch, toFind);
            //Assert
            Assert.IsInstanceOf<IEnumerable<int>>(result);
            Assert.That(result.ToList(), Is.EqualTo(expectedIndexes));
        }

        [Test]
        [TestCase("There is the truth in that sentence, the real truth", "untruth")]
        public void BoyereMooreHorsPoool_OnPredefinedParameters_ReturnsEmptyCollection(string toSearch, string toFind)
        {
            //Act
            var result = BoyereMooreHorspool.GetMatches(toSearch, toFind);
            //Assert
            Assert.IsInstanceOf<IEnumerable<int>>(result);
            Assert.That(result.ToList(), Is.Empty);
        }

        #endregion

        #region Edge cases
        [Test]
        public void BoyereMooreHorsPoool_OnEmptyToSearchString_ReturnsArgumentOutOfRangeException()
        {
            //Assert
            Assert.That(() => BoyereMooreHorspool.GetMatches(null, "ToSearch").ToArray(), Throws.TypeOf<ArgumentOutOfRangeException>().With.Property("ParamName").EqualTo("toSearch"));
        }

        [Test]
        public void BoyereMooreHorsPoool_OnEmptyToFindString_ReturnsArgumentOutOfRangeException()
        {
            //Assert
            Assert.That(() => BoyereMooreHorspool.GetMatches("toSearch", null).ToArray(), Throws.TypeOf<ArgumentOutOfRangeException>().With.Property("ParamName").EqualTo("toFind"));
            Assert.Throws<ArgumentOutOfRangeException>(() => BoyereMooreHorspool.GetMatches("toSearch", null).ToArray());
        }
        #endregion




    }
}
