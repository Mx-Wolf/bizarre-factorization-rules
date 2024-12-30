namespace FizzBuzz.Cli;

public class Driver(Generator generator, Formatter formatter, Collector collector)
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