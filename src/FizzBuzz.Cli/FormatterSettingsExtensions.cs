namespace FizzBuzz.Cli;

public static class FormatterSettingsExtensions
{
    public static string Both(this FormatterSettings self) => $"{self.Smaller}{self.Larger}";
}