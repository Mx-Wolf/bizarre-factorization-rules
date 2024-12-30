using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Generator(IOptions<GeneratorSettings> options)
{
    public IEnumerable<int> GetRange()
    {
        return GetRangeInternal(options.Value);
    }

    public static Generator CreateDefault()
    {
        return new Generator(Options());
    }

    public static IOptions<GeneratorSettings> Options()
    {
        var generatorSettings = new GeneratorSettings()
        {
            LowerBoundary = GeneratorSettings.LowerBoundaryInternal,
            UpperBoundary = GeneratorSettings.UpperBoundaryInternal,
        };
        IOptions<GeneratorSettings> options = new OptionsWrapper<GeneratorSettings>(generatorSettings);
        return options;
    }

    private static IEnumerable<int> GetRangeInternal(GeneratorSettings generatorSettings)
    {
        return Enumerable.Range(generatorSettings.LowerBoundary, generatorSettings.UpperBoundary-generatorSettings.LowerBoundary+1);
    }
}