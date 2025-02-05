using FizzBuzz.Cli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json", optional: true)
           .Build();

        var services = new ServiceCollection();
        services.AddSingleton<IDriver, Driver>();
        services.AddSingleton<IFormatter, Formatter>();

        services.Configure<FormatterSettings>(configuration.GetSection(FormatterSettings.Key));

        var sp = services.BuildServiceProvider();
        sp.GetRequiredService<IDriver>().Execute();
    }

}
