using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli;

public class Formatter(IOptions<FormatterSettings> options)
{
    private readonly string fizzBuzz = options.Value.FizzBuzz();

    public string Format(int i)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            return fizzBuzz;
        }

        if (i % 3 == 0)
        {
            return options.Value.Fizz;
        }

        if (i % 5 == 0)
        {
            return options.Value.Buzz;
        }

        var value = i.ToString();
        return (value);
    }
}