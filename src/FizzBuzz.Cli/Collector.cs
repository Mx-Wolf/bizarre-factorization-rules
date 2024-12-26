namespace FizzBuzz.Cli;

public class Collector(TextWriter writer)
{
    public void Collect(string line)
    {
        writer.WriteLine(line);
    }
}