using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public static partial class RulesLoggerMessages
{
    [LoggerMessage(Level = LogLevel.Trace, Message = "Rule3WorkedWith {i}")]
    public static partial void Rule3WorkedWith(this ILogger logger, int i);
}