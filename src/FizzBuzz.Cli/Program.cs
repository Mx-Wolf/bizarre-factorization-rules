using FizzBuzz.Cli;

internal class Program
{
    public static void Main(string[] args)
    {
        var outFormatProvider = Console.Out.FormatProvider;
        var formatter = new Formatter(outFormatProvider);
        var generator = new Generator(1, 100);
        foreach(var i in generator.GetSequence())
        {
            var line = formatter.Format(i);
            Console.WriteLine(line);
        }
    }
}
