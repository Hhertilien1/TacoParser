using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            
            var tacoParser = new TacoParser();

            
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        
        public void ShouldParseLongitude(string line, double expected)
        {
            

            
            var tacoParser = new TacoParser();

            
            var actual = tacoParser.Parse(line).Location.Longitude;

            
            Assert.Equal(actual, expected);
        }

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
