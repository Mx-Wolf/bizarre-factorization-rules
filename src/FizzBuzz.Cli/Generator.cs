using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Generator(IOptions<GeneratorSettings> options) : IGenerator
{
    public IEnumerable<int> GetRange()
    {
        var enumerable = Enumerable.Range(options.Value.Lo,(options.Value.Hi-options.Value.Lo)+1);
        return enumerable;
    }
}