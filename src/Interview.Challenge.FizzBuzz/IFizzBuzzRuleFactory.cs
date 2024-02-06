namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents a factory for generating FizzBuzz rules.
    /// </summary>
    public interface IFizzBuzzRuleFactory
    {
        /// <summary>
        /// Gets a collection of FizzBuzz rules in the desired order.
        /// </summary>
        /// <returns>The collection of FizzBuzz rules.</returns>
        IFizzBuzzRule[] GetRules();
    }
}