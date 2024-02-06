namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents a rule for the FizzBuzz game.
    /// </summary>
    public interface IFizzBuzzRule
    {
        /// <summary>
        /// Gets the name of the rule.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Checks if the given number satisfies the rule.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if the number satisfies the rule, otherwise false.</returns>
        bool CheckRule(int number);
    }
}