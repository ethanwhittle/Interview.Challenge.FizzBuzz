using System.Globalization;

namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents the engine for applying FizzBuzz rules to a given number.
    /// </summary>
    public class FizzBuzzEngine : IFizzBuzzEngine
    {
        private readonly IFizzBuzzRule[] _rules;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzEngine"/> class.
        /// </summary>
        /// <param name="fizzBuzzRuleFactory">The factory used to create FizzBuzz rules.</param>
        public FizzBuzzEngine(IFizzBuzzRuleFactory fizzBuzzRuleFactory)
        {
            ArgumentNullException.ThrowIfNull(fizzBuzzRuleFactory);

            _rules = fizzBuzzRuleFactory.GetRules();
        }

        /// <summary>
        /// Applies FizzBuzz rules to the given number and returns the result.
        /// </summary>
        /// <param name="number">The number to apply FizzBuzz rules to.</param>
        /// <returns>The FizzBuzz result.</returns>
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
                result = number.ToString(CultureInfo.InvariantCulture);
            }

            return result;
        }
    }
}