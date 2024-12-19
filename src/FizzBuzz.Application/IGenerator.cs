namespace FizzBuzz.Application;

public interface IGenerator
{
    IEnumerable<string> Sequence();
}