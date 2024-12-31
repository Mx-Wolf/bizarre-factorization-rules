using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Formatter(IOptions<FormatterSettings> options, IRules rules) : IFormatter
{
    private readonly string fizzBuzz = options.Value.FizzBuzz();
    
    public string Format(int i)
    {
        return (
                rules.MultipleToSmallDivisor(i), 
                rules.MultipleToLargeDivisor(i)) switch
        {
            (true, true) => fizzBuzz,
            (true, _) => options.Value.Fizz,
            (_, true) => options.Value.Buzz,
            _ => i.ToString(),
        };
}
}