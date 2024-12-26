using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Generator(OptionsWrapper<GeneratorSettings> options)
{
    public IEnumerable<int> GetRange()
    {
        var enumerable = Enumerable.Range(options.Value.Lo,(options.Value.Hi-options.Value.Lo)+1);
        return enumerable;
    }
}