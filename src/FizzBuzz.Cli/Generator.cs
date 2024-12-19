using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli
{
    public class Generator(IOptions<GeneratorSettings> settings, IFormatter formatter): IGenerator
    {
        public IEnumerable<string> AllLines()
        {
            return Enumerable.Range(settings.Value.Start, settings.Value.Count).Select(formatter.FormatWithRules);
        }
    }
}
