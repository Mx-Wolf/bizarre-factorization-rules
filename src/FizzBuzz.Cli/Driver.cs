namespace FizzBuzz.Cli;

public class Driver(IGenerator generator, IFormatter formatter, ICollector collector) : IDriver
{
    public void Execute()
    {
        foreach (var i in generator.GetRange())
        {
            var line = formatter.Format(i);
            collector.Collect(line);
        }
    }
}