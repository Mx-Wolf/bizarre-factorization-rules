using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Cli;

internal static class Program
{
    public static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true).Build();
        var services = new ServiceCollection();
        services.AddOptions<FormatterSettings>().Bind(configuration.GetSection(nameof(FormatterSettings)));
        services.AddOptions<RulesSettings>().Bind(configuration.GetSection(nameof(RulesSettings)));
        services.AddOptions<GeneratorSettings>().Bind(configuration.GetSection(nameof(GeneratorSettings)));

        services.AddSingleton<IRules, Rules>();
        services.AddSingleton<IFormatter, Formatter>();
        services.AddSingleton<IGenerator, Generator>();
        services.AddSingleton<ICollector, Collector>();
        services.AddSingleton<IDriver, Driver>();
        
        var serviceProvider = services.BuildServiceProvider();
        var driver = serviceProvider.GetRequiredService<IDriver>();
        driver.Execute();
    }
}