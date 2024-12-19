// See https://aka.ms/new-console-template for more information

using FizzBuzz.Cli;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();
builder.Services.AddSingleton<IDriver, Driver>();
builder.Services.AddSingleton<IGenerator, Generator>();
builder.Services.AddSingleton<IFormatter, Formatter>();
builder.Services.AddSingleton<IRules, Rules>();
builder.Services.AddOptions<WordSettings>().Bind(builder.Configuration.GetSection(nameof(WordSettings)));
builder.Services.AddOptions<GeneratorSettings>().Bind(builder.Configuration.GetSection(nameof(GeneratorSettings)));
builder.Services.AddSingleton<Action<string>>(Console.WriteLine);
builder.Services.AddHostedService<Service>();

var app = builder.Build();

await app.RunAsync();
