using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class RuleOrderAttribute : Attribute
    {
        public RuleOrderAttribute(int order)
        {
            // ENHANCE: Do we care about negative order values?
            Order = order;
        }

        public int Order { get; }
    }

    public class RuleOrderAttributeTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void RuleOrderAttribute_CanBeConstructed(int value)
        {
            // Arrange / Act
            var ruleOrderAttribute = new RuleOrderAttribute(value);

            // Assert
            ruleOrderAttribute.Order.Should().Be(value);
        }
    }
}