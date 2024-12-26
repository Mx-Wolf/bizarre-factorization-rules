using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Formatter : IFormatter
{
    private readonly IFormatProvider outFormatProvider;
    private readonly IOptions<FormatterSettings> options;
    private readonly string both;
    private readonly Rules rules;

    public Formatter(IFormatProvider outFormatProvider, OptionsWrapper<FormatterSettings> options, Rules rules)
    {
        this.options = options;
        this.both = $"{this.options.Value.Smaller}{this.options.Value.Larger}";
        this.outFormatProvider = outFormatProvider;
        this.rules = rules;
    }

    public string Format(int i) =>
        (rules.IsSmaller1(i), rules.IsLarger1(i)) switch
        {
            (true, true) => this.both,
            (true, _) => this.options.Value.Smaller,
            (_, true) => this.options.Value.Larger,
            _ => i.ToString(outFormatProvider)
        };
}