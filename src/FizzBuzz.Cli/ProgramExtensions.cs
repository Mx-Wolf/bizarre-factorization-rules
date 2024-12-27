using FizzBuzz.Cli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ProgramExtensions
{
    public static IServiceCollection Bootstrap(this IServiceCollection services, IConfigurationRoot configuration)
    {
        services.AddSingleton(Console.Out);
        services.AddSingleton(sp => sp.GetRequiredService<TextWriter>().FormatProvider);

        services.AddOptions()
            .Configure<FormatterSettings>(configuration.GetSection(nameof(FormatterSettings)))
            .Configure<GeneratorSettings>(configuration.GetSection(nameof(GeneratorSettings)))
            .Configure<RulesSettings>(configuration.GetSection(nameof(RulesSettings)))
            ;

        services.AddSingleton<IRules, Rules>();

        services.AddSingleton<IFormatter, Formatter>();

        services.AddSingleton<IGenerator, Generator>();

        services.AddSingleton<ICollector, Collector>();

        services.AddSingleton<IDriver, Driver>();
        return services;
    }
}