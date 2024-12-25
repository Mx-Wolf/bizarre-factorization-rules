namespace FizzBuzz.Cli;

public class Driver(IGenerator generator, IFormatter formatter, ICollector collector) : IDriver
{
    public void Execute()
    {
        foreach (var i in generator.GetSequence())
        {
            collector.Collect(formatter.Format(i));
        }
    }
}