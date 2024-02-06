using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzBuzzEngineTests
    {
        [Theory]
        [InlineData(1)]
        public void FizzBuzzEngine_Returns_Number_When_No_Rules_Apply(int value)
        {
            // Arrange
            var rules = Substitute.For<IFizzBuzzRule[]>();

            var engine = new FizzBuzzEngine(rules);

            // Act
            var result = engine.Apply(value);

            // Assert
            result.Should().Be(value.ToString());
        }
    }
}