// See https://aka.ms/new-console-template for more information

using FizzBuzz.Cli;

Action<string> callback = Console.WriteLine;
var generator = new Generator(1, 100);
foreach (var result in generator.AllLines())
{
    callback(result);
}
