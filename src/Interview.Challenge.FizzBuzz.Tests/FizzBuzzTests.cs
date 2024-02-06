using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public class FizzBuzz()
    {
        public string GetFizzyBuzzy(int number)
        {
            if (number == 3)
            {
                return "Fizz";
            }

            throw new NotImplementedException();
        }
    }

    public class FizzBuzzTests
    {
        [Fact]
        public void FizzBuzz_Returns_Fizz_For_Multiples_Of_3()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GetFizzyBuzzy(3);

            // Assert
            result.Should().Be("Fizz");
        }
    }
}