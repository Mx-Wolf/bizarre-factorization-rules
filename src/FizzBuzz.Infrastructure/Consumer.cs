using FizzBuzz.Application;

namespace FizzBuzz.Infrastructure;

public class Consumer:IConsumer
{
    public void Accept(string value)
    {
        Console.WriteLine(value);
    }
}