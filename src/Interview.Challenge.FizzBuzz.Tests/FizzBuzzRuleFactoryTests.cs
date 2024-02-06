using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
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
        }
    }
}