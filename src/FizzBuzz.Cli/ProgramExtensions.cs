using FizzBuzz.Application;
using FizzBuzz.Formatter.Divisibility;
using FizzBuzz.Generator.IntegerSequence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public static class ProgramExtensions
{
    public static IServiceCollection Bootstrap(this IServiceCollection services, IConfigurationRoot configuration)
    {
        services.AddLogging(b =>
        {
            b.AddConfiguration(configuration.GetSection("Logging"));
            b.AddConsole();
        });
        
        services.AddOptions<FormatterSettings>().Bind(configuration.GetSection(nameof(FormatterSettings)));
        services.AddOptions<RulesSettings>().Bind(configuration.GetSection(nameof(RulesSettings)));
        services.AddOptions<GeneratorSettings>().Bind(configuration.GetSection(nameof(GeneratorSettings)));

        services.AddSingleton(Console.Out);

        services.AddSingleton<IRules, Rules>();

        services.AddSingleton<IFormatter, Formatter.Divisibility.Formatter>();

        services.AddSingleton<IGenerator, Generator.IntegerSequence.Generator>();

        services.AddSingleton<ICollector, Collector.TextWriter.Collector>();

        services.AddSingleton<IDriver, Driver>();
        return services;
    }
}