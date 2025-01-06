namespace FizzBuzz.Application;

public interface IGenerator
{
    IEnumerable<int> GetRange();
}