﻿namespace Interview.Challenge.FizzBuzz.Tests
{
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