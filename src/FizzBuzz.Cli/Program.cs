using FizzBuzz.Cli;

internal class Program
{
    public static void Main(string[] args)
    {
        var textWriter = Console.Out;
        var outFormatProvider = textWriter.FormatProvider;
        var formatter = new Formatter(outFormatProvider);
        var generator = new Generator(1, 100);
        var collector = new Collector(textWriter);
        var driver = new Driver(generator, formatter, collector);
        driver.Execute();
    }
}
