using Microsoft.Extensions.Options;

namespace FizzBuzz.Formatter.Divisibility;

public class Rules(IOptions<RulesSettings> options) : IRules
{
    public bool MultipleToLargeDivisor(int i)
    {
        return i % options.Value.LargerDivisor == 0;
    }

    public bool MultipleToSmallDivisor(int i)
    {
        return i % options.Value.SmallerDivisor == 0;
    }
}