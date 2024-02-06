using System.Reflection;

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

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void FizzRule_Returns_False_For_Non_Multiples_Of_3(int number)
        {
            // Act
            var result = _testClass.CheckRule(number);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void FizzRule_CanGet_Name()
        {
            // Assert
            _testClass.Name.Should().NotBeNull().And.Be("Fizz");
        }

        [Fact]
        public void FizzRule_Has_RuleOrderAttribute()
        {
            // Act
            var result = _testClass.GetType().GetCustomAttribute<RuleOrderAttribute>();

            // Assert
            result.Should().NotBeNull();
            result!.Order.Should().Be(1);
        }
    }
}