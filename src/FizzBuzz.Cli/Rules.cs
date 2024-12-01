namespace FizzBuzz.Cli;

public class Rules(int i)
{
    public bool Rule5()
    {
        return i % 5 == 0;
    }

    public bool Rule3()
    {
        return i % 3 == 0;
    }
}