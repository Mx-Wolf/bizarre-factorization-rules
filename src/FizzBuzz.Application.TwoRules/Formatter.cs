using Microsoft.Extensions.Options;

namespace FizzBuzz.Application.TwoRules
{
    public class Formatter( IRules rules, IOptions<WordSettings> options): IFormatter
    {
        public string FormatWithRules(int i)
        {
            if (rules.Rule3(i) && rules.Rule5(i))
            {
                return options.Value.FizzBuzz;
            }

            if (rules.Rule3(i))
            {
                return options.Value.Fizz;
            }

            return rules.Rule5(i) ? options.Value.Buzz : i.ToString();
        }
    }
}
