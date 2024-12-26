using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Rules(IOptions<RulesSettings> options) : IRules
{
    public bool IsSmaller(int i) => i % options.Value.Smaller == 0;

    public bool IsLarger(int i) => i % options.Value.Larger == 0;
}