using System;
using Xunit;

namespace ArraysAndStrings.Tests
{
    
    public class AnagramGeneratorTest{

        [Fact]
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