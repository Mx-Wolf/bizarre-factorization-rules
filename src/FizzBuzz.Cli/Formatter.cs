namespace FizzBuzz.Cli;

public class Formatter(IFormatProvider formatProvider, IRules rules) : IFormatter
{
    public string Format(int i) =>
        (rules.RuleSmallerDivisor(i), rules.RuleLargerDivisor(i)) switch
        {
            (true, true) => "FizzBuzz",
            (true, _) => "Fizz",
            (_, true) => "Buzz",
            _ => i.ToString(formatProvider)
        };
}