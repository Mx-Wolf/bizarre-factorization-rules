namespace FizzBuzz.Formatter.Divisibility;

public interface IRules
{
    bool MultipleToLargeDivisor(int i);
    bool MultipleToSmallDivisor(int i);
}