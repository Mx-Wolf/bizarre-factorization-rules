namespace FizzBuzz.Cli;

public interface IGenerator
{
    IEnumerable<string> AllLines();
}