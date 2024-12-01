namespace FizzBuzz.Cli;

public class Factory(
    string fizzBuzz = "FizzBuzz",
    string fizz = "Fizz",
    string buzz = "Buzz") : IFactory
{
    private IFormatInt? fizzBuzzFormat;
    private IFormatInt? fizzFormat;
    private IFormatInt? buzzFormat;
    private IFormatInt? noneFormat;
    public IFormatInt None() => noneFormat ??= new FormatInt();

    public IFormatInt Buzz() => buzzFormat ??= new LiteralFormatInt(buzz);

    public IFormatInt Fizz() => fizzFormat ??= new LiteralFormatInt(fizz);

    public IFormatInt FizzBuzz() => fizzBuzzFormat ??= new LiteralFormatInt(fizzBuzz);
}