// See https://aka.ms/new-console-template for more information

using FizzBuzz.Cli;

for (var i = 1; i <= 100; i++)
{
    var result = new Formatter(i).FormatWithRules();
    Console.WriteLine(result);
}

