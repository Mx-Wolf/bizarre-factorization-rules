using FizzBuzz.Application;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Collector.TextWriter;

public class Collector(ILogger<Collector> logger, System.IO.TextWriter textWriter) : ICollector
{
    public void Collect(string format)
{
        logger.CollectingFormattedLine(format);
        textWriter.WriteLine(format);
    }
}