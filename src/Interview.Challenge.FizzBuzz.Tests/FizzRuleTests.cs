using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzRule()
    {
        public bool CheckRule(int number)
        {
            if (number % 3 == 0)
            {
                return true;
            }

            return false;
        }
    }

    public class FizzRuleTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void FizzRule_Returns_True_For_Multiples_Of_3(int number)
        {
            // Arrange
            var fizzRule = new FizzRule();

            // Act
            var result = fizzRule.CheckRule(number);

            // Assert
            result.Should().BeTrue();
        }
    }
}