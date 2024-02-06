namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzRuleTests
    {
        private readonly FizzRule _testClass;

        public FizzRuleTests()
        {
            _testClass = new FizzRule();
        }

        [Fact]
        public void FizzRule_CanConstruct()
        {
            // Arrange
            var instance = new FizzRule();

            // Assert
            instance.Should().NotBeNull();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void FizzRule_Returns_True_For_Multiples_Of_3(int number)
        {
            // Act
            var result = _testClass.CheckRule(number);

            // Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void FizzRule_CanGetName()
        {
            // Assert
            _testClass.Name.Should().NotBeNull().And.Be("Fizz");
        }
    }
}