using System.Reflection;

namespace Interview.Challenge.FizzBuzz
{
    public class FizzBuzzRuleFactory : IFizzBuzzRuleFactory
    {
        public IFizzBuzzRule[] GetRules()
        {
            var ruleTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            var rules = new List<(IFizzBuzzRule, int)>();

            foreach (var ruleType in ruleTypes)
            {
                var order = ruleType.GetCustomAttribute<RuleOrderAttribute>()?.Order;
                if (order is not null)
                {
                    var rule = Activator.CreateInstance(ruleType) as IFizzBuzzRule;
                    rules.Add((rule!, order.Value));
                }
            }

            return rules.OrderBy(r => r.Item2).Select(r => r.Item1).ToArray();
        }
    }
}