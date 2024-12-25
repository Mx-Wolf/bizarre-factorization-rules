namespace FizzBuzz.Cli;

public class Rules : IRules
{
    public bool RuleSmallerDivisor(int i) => i % 3 == 0;

    public bool RuleLargerDivisor(int i) => i % 5 == 0;
}