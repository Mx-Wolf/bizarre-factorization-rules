using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

internal static class Program
{
    public static void Main(string[] args)
    {
        var formatterSettings = new FormatterSettings()
        {
            Fizz = FormatterSettings.FizzInternal,
            Buzz = FormatterSettings.BuzzInternal,
        };
        var rulesSettings = new RulesSettings
        {
            LargerDivisor = RulesSettings.LargerDivisorInternal,
            SmallerDivisor = RulesSettings.SmallerDivisorInternal,
        };

        var generatorSettings = new GeneratorSettings()
        {
            LowerBoundary = GeneratorSettings.LowerBoundaryInternal,
            UpperBoundary = GeneratorSettings.UpperBoundaryInternal,
        };

        var formatterOptions = new OptionsWrapper<FormatterSettings>(formatterSettings);
        var rulesOptions = new OptionsWrapper<RulesSettings>(rulesSettings);
        var generatorOptions = new OptionsWrapper<GeneratorSettings>(generatorSettings);

        var rules = new Rules(rulesOptions);
        var formatter = new Formatter(formatterOptions, rules);
        var generator = new Generator(generatorOptions);
        var collector = new Collector();

        var driver = new Driver(generator, formatter, collector);

        driver.Execute();
    }
}