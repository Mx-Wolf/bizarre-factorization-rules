namespace FizzBuzz.Cli;

public class Collector(TextWriter writer) : ICollector
{
    public void Collect(string line) => writer.WriteLine(line);
}