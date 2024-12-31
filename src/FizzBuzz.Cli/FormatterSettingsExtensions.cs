namespace FizzBuzz.Cli;

public static class FormatterSettingsExtensions
{
    public static string FizzBuzz(this FormatterSettings formatterSettings)
    {
        return $"{formatterSettings.Fizz}{formatterSettings.Buzz}";
    }
}