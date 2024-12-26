using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

internal class Program
{
    public static void Main(string[] args)
    {
        var textWriter = Console.Out;
        var outFormatProvider = textWriter.FormatProvider;
        
        var formatterSettings = new FormatterSettings
        {
            Larger = "Buzz",
            Smaller = "Fizz"
        };
        var generatorSettings = new GeneratorSettings
        {
            Hi = 100,
            Lo = 1,
        };
        var rulesSettings = new RulesSettings
        {
            Larger = 5, 
            Smaller = 3
        };
        
        var formatterOptions = new OptionsWrapper<FormatterSettings>(formatterSettings);
        var generatorOptions = new OptionsWrapper<GeneratorSettings>(generatorSettings);
        var optionsWrapper = new OptionsWrapper<RulesSettings>(rulesSettings);
        
        var rules = new Rules(optionsWrapper);

        var formatter = new Formatter(outFormatProvider, formatterOptions, rules);
        var generator = new Generator(generatorOptions);
        var collector = new Collector(textWriter);

        var driver = new Driver(generator, formatter, collector);

        driver.Execute();
    }
}