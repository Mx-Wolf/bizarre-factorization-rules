using FizzBuzz.Cli;

public class Driver(Generator generator, Formatter formatter, Collector collector)
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