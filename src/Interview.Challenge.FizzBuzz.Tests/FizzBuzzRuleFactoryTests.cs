using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzBuzzRuleFactory
    {
        public IFizzBuzzRule[] GetRules()
        {
            return [new FizzRule(), new BuzzRule()];
        }
    }

    public class FizzBuzzRuleFactoryTests
    {
        [Fact]
        public void GetRules_Returns_Rules()
        {
            // Arrange
            var factory = new FizzBuzzRuleFactory();

            // Act
            IFizzBuzzRule[] rules = factory.GetRules();

            // Assert
            rules.Should().NotBeNull().And.HaveCount(2);
            rules[0].Should().BeOfType<FizzRule>();
            rules[1].Should().BeOfType<BuzzRule>();
        }
    }
}