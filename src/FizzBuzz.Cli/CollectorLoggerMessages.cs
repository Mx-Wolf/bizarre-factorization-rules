using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public static partial class CollectorLoggerMessages
{
    [LoggerMessage(Level = LogLevel.Trace, Message = "CollectingFormattedLine {format}")]
    public static partial void CollectingFormattedLine(this ILogger logger, string format);
}