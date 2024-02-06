﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
            var ruleTypes = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            var rules = new List<IFizzBuzzRule>();

            foreach (var ruleType in ruleTypes)
            {
                var rule = Activator.CreateInstance(ruleType) as IFizzBuzzRule;
                rules.Add(rule!);
            }

            return [.. rules];
        }
    }

    public class FizzBuzzRuleFactoryTests
    {
        [Fact]
        public void GetRules_Returns_Rules()
        {
            // Arrange
            var factory = new FizzBuzzRuleFactory();

            // Act
            IFizzBuzzRule[] rules = factory.GetRules();

            // Assert
            rules.Should().NotBeNull().And.HaveCount(2);
            rules[0].Should().BeOfType<FizzRule>();
            rules[1].Should().BeOfType<BuzzRule>();
        }
    }
}