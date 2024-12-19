// See https://aka.ms/new-console-template for more information

using FizzBuzz.Cli;
using Microsoft.Extensions.Hosting;

await Host.CreateApplicationBuilder()
    .Bootstrap()
    .Build()
    .RunAsync();

