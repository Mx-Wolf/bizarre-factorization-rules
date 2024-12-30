namespace FizzBuzz.Cli;

public class RulesSettings
{
    public required int LargerDivisor { get; init; }
    public required int SmallerDivisor { get; init; }

    public static RulesSettings CreateDefault()
    {
        return new RulesSettings
        {
            LargerDivisor = LargerDivisorInternal,
            SmallerDivisor = SmallerDivisorInternal,
        };
    }

    public static int LargerDivisorInternal => 5;

    public static int SmallerDivisorInternal => 3;
}