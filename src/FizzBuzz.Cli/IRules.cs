namespace FizzBuzz.Cli;

public interface IRules
{
    bool RuleSmallerDivisor(int i);
    bool RuleLargerDivisor(int i);
}