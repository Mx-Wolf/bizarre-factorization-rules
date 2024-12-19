namespace FizzBuzz.Cli;

public class Driver(IGenerator generator, IConsumer consumer): IDriver
{
    public void Run()
    {
        foreach (var line in generator.AllLines())
        {
            consumer.Accept(line);
        }
    }
}