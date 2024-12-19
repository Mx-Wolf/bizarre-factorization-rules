namespace FizzBuzz.Cli;

public class Consumer:IConsumer
{
    public void Accept(string value)
    {
        Console.WriteLine(value);
    }
}