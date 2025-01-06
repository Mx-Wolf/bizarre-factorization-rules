using FizzBuzz.Application;
using Microsoft.Extensions.Options;

namespace FizzBuzz.Generator.IntegerSequence;

public class Generator(IOptions<GeneratorSettings> options) : IGenerator
{
    public IEnumerable<int> GetRange()
    {
        return Enumerable.Range(options.Value.LowerBoundary, options.Value.UpperBoundary-options.Value.LowerBoundary+1);
    }
}