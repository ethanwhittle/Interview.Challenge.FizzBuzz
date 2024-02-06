using System.Reflection;

namespace Interview.Challenge.FizzBuzz.Tests
{
    public interface IFizzBuzzRuleFactory
    {
        IFizzBuzzRule[] GetRules();
    }

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

    public class FizzBuzzRuleFactoryTests
    {
        private readonly FizzBuzzRuleFactory _testClass;

        public FizzBuzzRuleFactoryTests()
        {
            _testClass = new FizzBuzzRuleFactory();
        }

        [Fact]
        public void GetRules_Returns_Rules()
        {
            // Arrange / Act
            IFizzBuzzRule[] rules = _testClass.GetRules();

            // Assert
            rules.Should().NotBeNull().And.HaveCount(2);
            rules[0].Should().BeOfType<FizzRule>();
            rules[1].Should().BeOfType<BuzzRule>();
        }

        [Fact]
        public void Order_IsReadOnly()
        {
            // Act
            var orderProperty = typeof(RuleOrderAttribute).GetProperty("Order");

            // Assert
            orderProperty.Should().NotBeNull();
            orderProperty!.CanWrite.Should().BeFalse();
        }
    }
}