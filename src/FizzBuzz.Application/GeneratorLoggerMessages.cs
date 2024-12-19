using Microsoft.Extensions.Logging;

namespace FizzBuzz.Application;

public static partial class GeneratorLoggerMessages
{
    [LoggerMessage(Level = LogLevel.Error, Message = "ErrorFoundWhileFormatting, {count}, {start}")]
    public static partial void ErrorFoundWhileFormatting(this ILogger logger, int count, int start, Exception ex);
}