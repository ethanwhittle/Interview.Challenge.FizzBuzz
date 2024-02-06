namespace Interview.Challenge.FizzBuzz
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class RuleOrderAttribute(int order) : Attribute
    {
        public int Order { get; } = order;
    }
}