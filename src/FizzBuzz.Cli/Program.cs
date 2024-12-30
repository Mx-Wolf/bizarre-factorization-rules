using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Cli;

internal static class Program
{
    public static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)
            .Build();

        var driver = new ServiceCollection()
            .Bootstrap(configuration)
            .BuildServiceProvider()
            .GetRequiredService<IDriver>();

        driver.Execute();
    }
}