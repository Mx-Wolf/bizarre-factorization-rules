using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Cli;

internal class Program
{
    public static void Main(string[] args)
    {
        new ServiceCollection()
            .Bootstrap(
                new ConfigurationBuilder()
                    .AddCommandLine(args)
                    .AddJsonFile("appsettings.json", optional: true)
                    .AddUserSecrets<Program>(optional: true)
                    .Build())
            .BuildServiceProvider()
            .GetRequiredService<IDriver>()
            .Execute();
    }
}