using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public class Driver(IGenerator generator, IFormatter formatter, ICollector collector, ILogger<Driver> logger) : IDriver
{
    public void Execute()
    {
        foreach (var i in generator.GetRange())
        {
            ExecuteStep(i);
        }
    }

    private void ExecuteStep(int i)
    {
        using (logger.BeginScope(new { i }))
        {

            var format = formatter.Format(i);
            collector.Collect(format);
        }
    }
}