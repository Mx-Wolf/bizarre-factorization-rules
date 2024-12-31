namespace FizzBuzz.Cli;

public interface IRules
{
    bool MultipleToLargeDivisor(int i);
    bool MultipleToSmallDivisor(int i);
}