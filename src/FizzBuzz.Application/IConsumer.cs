namespace FizzBuzz.Application;

public interface IConsumer
{
    public void Accept(string value);
}