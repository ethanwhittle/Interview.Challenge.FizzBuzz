using Interview.Challenge.FizzBuzz;

var start = 1;
var end = 100;

var factory = new FizzBuzzRuleFactory();
var engine = new FizzBuzzEngine(factory);

for (var i = start; i <= end; i++)
{
    var result = engine.Apply(i);

    Console.WriteLine(result);
}