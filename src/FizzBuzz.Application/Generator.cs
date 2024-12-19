using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FizzBuzz.Application
{
    public class Generator(IOptions<GeneratorSettings> settings, IFormatter formatter,ILogger<Generator> logger): IGenerator
    {
        public IEnumerable<string> Sequence()
        {
            try
            {
                return Enumerable.Range(settings.Value.Start, settings.Value.Count).Select(formatter.FormatWithRules);
            }
            catch (Exception e)
            {
                logger.ErrorFoundWhileFormatting(settings.Value.Count, settings.Value.Start, e);
                throw;
            }
        }
    }
}
