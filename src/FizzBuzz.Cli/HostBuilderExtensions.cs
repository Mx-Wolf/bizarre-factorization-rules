using FizzBuzz.Application;
using FizzBuzz.Application.TwoRules;
using FizzBuzz.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FizzBuzz.Cli;

public static class HostBuilderExtensions
{
    public static HostApplicationBuilder Bootstrap(this HostApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IDriver, Driver>();
        builder.Services.AddSingleton<IGenerator, Generator>();
        builder.Services.AddSingleton<IFormatter, Formatter>();
        builder.Services.AddSingleton<IRules, Rules>();
        builder.Services.AddSingleton<IConsumer, Consumer>();

        builder.Services.AddOptions<WordSettings>().Bind(builder.Configuration.GetSection(nameof(WordSettings)));
        builder.Services.AddOptions<GeneratorSettings>().Bind(builder.Configuration.GetSection(nameof(GeneratorSettings)));

        builder.Services.AddHostedService<Service>();

        return builder;
    }
}