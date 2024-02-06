using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public interface IFizzBuzzRule
    {
        string Name { get; }

        bool CheckRule(int number);
    }

    public class FizzRule : IFizzBuzzRule
    {
        public string Name => "Fizz";

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