namespace FizzBuzz.Cli;

public class FormatInt : IFormatInt
{
    public string Format(int x) => x.ToString();
}