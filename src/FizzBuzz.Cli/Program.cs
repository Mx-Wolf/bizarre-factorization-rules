using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

internal static class Program
{
    public static void Main(string[] args)
    {
        var formatterSettings = new FormatterSettings()
        {
            Fizz = FormatterSettings.FizzInternal,
            Buzz = FormatterSettings.BuzzInternal,
        };
        var formatterOptions = new OptionsWrapper<FormatterSettings>(formatterSettings);
        var formatter = new Formatter(formatterOptions);
        for (var i = 1; i <= 100; i++)
        {
            var format = formatter.Format(i);
            Console.WriteLine(format);
        }
    }
}