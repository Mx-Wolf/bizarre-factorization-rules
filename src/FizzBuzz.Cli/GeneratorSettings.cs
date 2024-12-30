namespace FizzBuzz.Cli;

public class GeneratorSettings
{
    public required int UpperBoundary { get; init; }
    public required int LowerBoundary { get; init; }

    public static GeneratorSettings CreateDefault()
    {
        return new GeneratorSettings()
        {
            LowerBoundary = LowerBoundaryInternal,
            UpperBoundary = UpperBoundaryInternal,
        };
    }

    public static int UpperBoundaryInternal => 100;
    public static int LowerBoundaryInternal => 1;
}