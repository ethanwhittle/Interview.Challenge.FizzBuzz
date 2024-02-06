namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzBuzzEngineTests
    {
        [Fact]
        public void FizzBuzzEngine_CanConstruct()
        {
            // Arrange
            var factory = Substitute.For<IFizzBuzzRuleFactory>();
            var engine = new FizzBuzzEngine(factory);

            // Assert
            engine.Should().NotBeNull();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void FizzBuzzEngine_Returns_Number_When_No_Rules_Apply(int value)
        {
            // Arrange
            var factory = Substitute.For<IFizzBuzzRuleFactory>();
            factory.GetRules().Returns(Array.Empty<IFizzBuzzRule>());
            var engine = new FizzBuzzEngine(factory);

            // Act
            var result = engine.Apply(value);

            // Assert
            result.Should().Be(value.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void FizzBuzzEngine_Returns_Fizz_When_Rizz_Rule_Applies(int value)
        {
            // Arrange
            var factory = Substitute.For<IFizzBuzzRuleFactory>();
            factory.GetRules().Returns([new FizzRule()]);
            var engine = new FizzBuzzEngine(factory);

            // Act
            var result = engine.Apply(value);

            // Assert
            result.Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void FizzBuzzEngine_Returns_Buzz_When_Buzz_Rule_Applies(int value)
        {
            // Arrange
            var factory = Substitute.For<IFizzBuzzRuleFactory>();
            factory.GetRules().Returns([new BuzzRule()]);
            var engine = new FizzBuzzEngine(factory);

            // Act
            var result = engine.Apply(value);

            // Assert
            result.Should().Be("Buzz");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzEngine_Returns_Correctly_When_Rules_Apply(int value, string expectedResult)
        {
            // Arrange
            var factory = Substitute.For<IFizzBuzzRuleFactory>();
            factory.GetRules().Returns([new FizzRule(), new BuzzRule()]);
            var engine = new FizzBuzzEngine(factory);

            // Act
            var result = engine.Apply(value);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}