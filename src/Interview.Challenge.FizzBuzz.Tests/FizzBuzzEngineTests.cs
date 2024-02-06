using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzBuzzEngine
    {
        private readonly IFizzBuzzRule[] _rules;

        public FizzBuzzEngine(IFizzBuzzRule[] rules)
        {
            ArgumentNullException.ThrowIfNull(rules);

            _rules = rules;
        }

        public string Apply(int number)
        {
            var result = string.Empty;

            foreach (var rule in _rules)
            {
                if (rule.CheckRule(number))
                {
                    result += rule.Name;
                }
            }

            if (string.IsNullOrWhiteSpace(result))
            {
                result = number.ToString();
            }

            return result;
        }
    }

    public class FizzBuzzEngineTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void FizzBuzzEngine_Returns_Number_When_No_Rules_Apply(int value)
        {
            // Arrange
            var engine = new FizzBuzzEngine([]);

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
            var engine = new FizzBuzzEngine([new FizzRule()]);

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
            var engine = new FizzBuzzEngine([new BuzzRule()]);

            // Act
            var result = engine.Apply(value);

            // Assert
            result.Should().Be("Buzz");
        }
    }
}