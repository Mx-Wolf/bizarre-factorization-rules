namespace FizzBuzz.Cli;

public class Rules : IRules
{
    public bool IsSmaller(int i)
    {
        return i % 3 == 0;
    }

    public bool IsLarger(int i)
    {
        return i % 5 == 0;
    }
}