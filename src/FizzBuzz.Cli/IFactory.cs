namespace FizzBuzz.Cli;

public interface IFactory
{
    IFormatInt None();
    IFormatInt Buzz();
    IFormatInt Fizz();
    IFormatInt FizzBuzz();
}