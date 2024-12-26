using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Formatter : IFormatter
{
    private readonly IFormatProvider formatProvider;
    private readonly IOptions<FormatterSettings> options;
    private readonly string both;
    private readonly IRules rules;

    public Formatter(IFormatProvider formatProvider, IOptions<FormatterSettings> options, IRules rules)
    {
        this.options = options;
        this.both = this.options.Value.Both();
        this.formatProvider = formatProvider;
        this.rules = rules;
    }

    public string Format(int i) =>
        (rules.IsSmaller(i), rules.IsLarger(i)) switch
        {
            (true, true) => this.both,
            (true, _) => this.options.Value.Smaller,
            (_, true) => this.options.Value.Larger,
            _ => i.ToString(formatProvider)
        };
}