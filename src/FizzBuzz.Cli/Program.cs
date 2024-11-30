// See https://aka.ms/new-console-template for more information

using FizzBuzz.Cli;

for (var i = 1; i <= 100; i++)
{
    var result = Formatter.FormatWithRules(i);
    Console.WriteLine(result);
}

