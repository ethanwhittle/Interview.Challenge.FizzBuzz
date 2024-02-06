namespace Interview.Challenge.FizzBuzz.Tests
{
    public class DefaultFizzBuzzRuleFactoryTests
    {
        private readonly DefaultFizzBuzzRuleFactory _testClass;

        public DefaultFizzBuzzRuleFactoryTests()
        {
            _testClass = new DefaultFizzBuzzRuleFactory();
        }

        [Fact]
        public void GetRules_Returns_Rules()
        {
            // Arrange / Act
            IFizzBuzzRule[] rules = _testClass.GetRules();

            // Assert
            rules.Should().NotBeNull().And.HaveCount(2);
            rules[0].Should().BeOfType<FizzRule>();
            rules[1].Should().BeOfType<BuzzRule>();
        }

        [Fact]
        public void Order_IsReadOnly()
        {
            // Act
            var orderProperty = typeof(RuleOrderAttribute).GetProperty("Order");

            // Assert
            orderProperty.Should().NotBeNull();
            orderProperty!.CanWrite.Should().BeFalse();
        }
    }
}