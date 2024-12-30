using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Cli;

public static class ProgramExtensions
{
    public static IServiceCollection Bootstrap(this IServiceCollection services, IConfigurationRoot configuration)
    {
        services.AddOptions<FormatterSettings>().Bind(configuration.GetSection(nameof(FormatterSettings)));
        services.AddOptions<RulesSettings>().Bind(configuration.GetSection(nameof(RulesSettings)));
        services.AddOptions<GeneratorSettings>().Bind(configuration.GetSection(nameof(GeneratorSettings)));

        services.AddSingleton<IRules, Rules>();
        services.AddSingleton<IFormatter, Formatter>();
        services.AddSingleton<IGenerator, Generator>();
        services.AddSingleton<ICollector, Collector>();
        services.AddSingleton<IDriver, Driver>();
        return services;
    }
}