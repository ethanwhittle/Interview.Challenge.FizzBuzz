namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents a rule for the FizzBuzz game where numbers divisible by 3 are replaced with "Fizz".
    /// </summary>
    public class FizzRule : IFizzBuzzRule
    {
        /// <summary>
        /// Gets the name of the rule, which is "Fizz".
        /// </summary>
        public string Name => "Fizz";

        /// <summary>
        /// Checks if the given number is divisible by 3.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is divisible by 3, otherwise false.</returns>
        public bool CheckRule(int number)
        {
            return number % 3 == 0;
        }
    }
}