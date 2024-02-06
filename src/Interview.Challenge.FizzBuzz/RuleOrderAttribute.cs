namespace Interview.Challenge.FizzBuzz
{
    /// <summary>
    /// Represents an attribute used to specify the order of rule application in the FizzBuzz game.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class RuleOrderAttribute(int order) : Attribute
    {
        /// <summary>
        /// Gets the order of rule application.
        /// </summary>
        public int Order { get; } = order;
    }
}