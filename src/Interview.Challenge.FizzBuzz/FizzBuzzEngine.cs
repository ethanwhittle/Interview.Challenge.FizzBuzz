namespace Interview.Challenge.FizzBuzz
{
    public class FizzBuzzEngine : IFizzBuzzEngine
    {
        private readonly IFizzBuzzRule[] _rules;

        public FizzBuzzEngine(IFizzBuzzRuleFactory fizzBuzzRuleFactory)
        {
            ArgumentNullException.ThrowIfNull(fizzBuzzRuleFactory);

            _rules = fizzBuzzRuleFactory.GetRules();
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
}