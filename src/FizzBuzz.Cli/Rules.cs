namespace FizzBuzz.Cli;

public class Rules():IRules
{
    public bool Rule5(int i)
    {
        return i % 5 == 0;
    }

    public bool Rule3(int i)
    {
        return i % 3 == 0;
    }
}