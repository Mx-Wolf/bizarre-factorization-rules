namespace FizzBuzz.Cli;

public class FormatterSettings
{
    public required string Buzz { get; init; }
    public required string Fizz { get; init; }

    public static string BuzzInternal => "Buzz";

    public static string FizzInternal => "Fizz";
}