namespace FizzBuzz.Application;

public class Driver(IGenerator generator, IConsumer consumer): IDriver
{
    public void Run()
    {
        foreach (var line in generator.Sequence())
        {
            consumer.Accept(line);
        }
    }
}