using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public class Collector(ILogger<Collector> logger) : ICollector
{
    public void Collect(string format)
    {
        logger.CollectingFormattedLine(format);
        Console.WriteLine(format);
    }
}