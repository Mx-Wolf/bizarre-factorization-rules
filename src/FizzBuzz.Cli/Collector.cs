namespace FizzBuzz.Cli;

public class Collector(TextWriter writer) : ICollector
{
    public void Collect(string format)
    {
        writer.WriteLine(format);
    }
}