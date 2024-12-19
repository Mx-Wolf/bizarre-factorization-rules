namespace FizzBuzz.Cli;

public class Driver(IGenerator generator, Action<string> callback): IDriver
{
    public void Run()
    {
        foreach (var result in generator.AllLines())
        {
            callback(result);
        }
    }
}