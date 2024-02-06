namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents a rule for the FizzBuzz game where numbers divisible by 5 are replaced with "Buzz".
    /// </summary>
    [RuleOrder(2)]
    public class BuzzRule : IFizzBuzzRule
    {
        /// <summary>
        /// Gets the name of the rule, which is "Buzz".
        /// </summary>
        public string Name => "Buzz";

        /// <summary>
        /// Checks if the given number is divisible by 5.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number is divisible by 5, otherwise false.</returns>
        public bool CheckRule(int number)
        {
            return number % 5 == 0;
        }
    }
}