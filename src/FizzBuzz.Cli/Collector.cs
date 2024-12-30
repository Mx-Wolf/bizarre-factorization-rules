namespace FizzBuzz.Cli;

public class Collector : ICollector
{
    public void Collect(string format)
    {
        Console.WriteLine(format);
    }
}