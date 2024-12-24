// See https://aka.ms/new-console-template for more information
using FizzBuzz.Cli;

var originalOut = Console.Out;
var newOut = new CustomWriter(originalOut);
Console.SetOut(newOut);

for (var i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
    
}
