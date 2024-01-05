using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;

            //Assert
            Assert.Equal(actual, expected);
        }


        //TODO: Create a test called ShouldParseLatitude DONE

        [Theory]
        [InlineData("33.587217, -85.057114, Taco Bell Carrollto...", 33.587217)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var tacoParser = new TacoParser();


            var actual = tacoParser.Parse(line).Location.Latitude;

            Assert.Equal(actual, expected);
        }

    }
}
