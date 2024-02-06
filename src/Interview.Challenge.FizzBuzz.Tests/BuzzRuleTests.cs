using System.Reflection;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class BuzzRuleTests
    {
        private readonly BuzzRule _testClass;

        public BuzzRuleTests()
        {
            _testClass = new BuzzRule();
        }

        [Fact]
        public void BuzzRule_CanConstruct()
        {
            // Arrange
            var instance = new BuzzRule();

            // Assert
            instance.Should().NotBeNull();
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void BuzzRule_Returns_True_For_Multiples_Of_5(int number)
        {
            // Act
            var result = _testClass.CheckRule(number);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void BuzzRule_Returns_False_For_Non_Multiples_Of_5(int number)
        {
            // Act
            var result = _testClass.CheckRule(number);

            // Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void BuzzRule_CanGet_Name()
        {
            // Assert
            _testClass.Name.Should().NotBeNull().And.Be("Buzz");
        }

        [Fact]
        public void BuzzRule_Has_RuleOrderAttribute()
        {
            // Act
            var result = _testClass.GetType().GetCustomAttribute<RuleOrderAttribute>();

            // Assert
            result.Should().NotBeNull();
            result!.Order.Should().Be(2);
        }
    }
}