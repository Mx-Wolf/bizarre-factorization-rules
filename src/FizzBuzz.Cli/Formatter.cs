using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Formatter(IFormatProvider formatProvider, IOptions<FormatterSettings> options, IRules rules) : IFormatter
{
    private readonly string both = options.Value.Both();
    
    public string Format(int i) =>
        (rules.IsSmaller(i), rules.IsLarger(i)) switch
        {
            (true, true) => this.both,
            (true, _) => options.Value.Smaller,
            (_, true) => options.Value.Larger,
            _ => i.ToString(formatProvider)
        };
}