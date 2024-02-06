namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents the interface for applying FizzBuzz rules to a given number.
    /// </summary>
    public interface IFizzBuzzEngine
    {
        /// <summary>
        /// Applies FizzBuzz rules to the given number and returns the result.
        /// </summary>
        /// <param name="number">The number to apply FizzBuzz rules to.</param>
        /// <returns>The FizzBuzz result.</returns>
        string Apply(int number);
    }
}