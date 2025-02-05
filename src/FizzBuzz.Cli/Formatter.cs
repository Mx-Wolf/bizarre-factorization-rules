using Microsoft.Extensions.Options;

namespace FizzBuzz.Cli
{
    public class Formatter : IFormatter
    {
        private readonly FormatterSettings _formatterSettings;

        public Formatter(IOptions<FormatterSettings> formatterSettings)
        {
            _formatterSettings = formatterSettings.Value;
        }

        public string Format(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return (_formatterSettings.Fizz + _formatterSettings.Buzz);
            }
            if (i % 3 == 0)
            {
                return (_formatterSettings.Fizz);
            }
            if (i % 5 == 0)
            {
                return (_formatterSettings.Buzz);
            }
            return (i.ToString());
        }
    }
}