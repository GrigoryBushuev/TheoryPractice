using NUnit.Framework;

namespace ArraysAndStrings.Test
{
    [TestFixture]
    public class AnagramGeneratorTest{

        [Test]
        public void AnagramGenerator_Generates_Test()
        {
             //Arrange
            var testString = "ABCD";                
             //Act
            var result = AnagramGenerator.Generate(testString);
             //Assert
             foreach (var item in result)
             {
                 
             }
        }
    }
}