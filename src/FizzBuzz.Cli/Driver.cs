using FizzBuzz.Cli;

public class Driver(IGenerator generator, IFormatter formatter, ICollector collector) : IDriver
{
    public void Execute()
    {
        foreach (var i in generator.GetSequence())
        {
            var line = formatter.Format(i);
            collector.Collect(line);
        }
    }
}