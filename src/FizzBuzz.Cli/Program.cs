using FizzBuzz.Cli;

internal class Program
{
    public static void Main(string[] args)
    {
        var outFormatProvider = Console.Out.FormatProvider;
        var formatter = new Formatter(outFormatProvider);
        for (var i = 1; i <= 100; i++)
        {
            var line = formatter.Format(i);
            Console.WriteLine(line);
        }
    }
}
