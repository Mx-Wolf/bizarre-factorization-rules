namespace FizzBuzz.Cli;

public class LiteralFormatInt(string literal):IFormatInt
{
    public string Format(int x) => literal;
}