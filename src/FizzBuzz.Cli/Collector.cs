using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public class Collector(ILogger<Collector> logger, TextWriter textWriter) : ICollector
{
    public void Collect(string format)
{
        logger.CollectingFormattedLine(format);
        textWriter.WriteLine(format);
    }
}