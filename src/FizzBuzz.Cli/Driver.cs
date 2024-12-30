namespace FizzBuzz.Cli;

public class Driver(IGenerator generator, IFormatter formatter, ICollector collector) : IDriver
{
    public void Execute()
    {
        foreach (var i in generator.GetRange())
        {
            var format = formatter.Format(i);
            collector.Collect(format);
        }
    }
}