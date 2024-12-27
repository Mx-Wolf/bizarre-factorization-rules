using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Generator(IOptions<GeneratorSettings> options) : IGenerator
{
    public IEnumerable<int> GetRange() => Enumerable.Range(options.Value.Lo,(options.Value.Hi-options.Value.Lo)+1);
}