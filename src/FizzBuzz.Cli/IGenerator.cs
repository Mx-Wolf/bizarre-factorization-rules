namespace FizzBuzz.Cli;

public interface IGenerator
{
    IEnumerable<int> GetRange();
}