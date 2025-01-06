using System.Reflection;
using FizzBuzz.Application;
using FizzBuzz.Cli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true)
    .AddUserSecrets(Assembly.GetExecutingAssembly())
    .AddCommandLine(args)
    .Build();

var driver = new ServiceCollection()
    .Bootstrap(configuration)
    .BuildServiceProvider()
    .GetRequiredService<IDriver>();

driver.Execute();