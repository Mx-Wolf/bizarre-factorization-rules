using Microsoft.Extensions.Logging;

namespace FizzBuzz.Cli;

public class Rules(ILogger<Rules> logger):IRules
{
    public bool Rule5(int i)
    {
        return i % 5 == 0;
    }

    public bool Rule3(int i)
    {
        logger.Rule3WorkedWith(i);
        return i % 3 == 0;
    }
}