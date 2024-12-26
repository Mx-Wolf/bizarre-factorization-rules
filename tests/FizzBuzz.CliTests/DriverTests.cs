using FizzBuzz.Cli;
using Moq;

namespace FizzBuzz.CliTests;

public class DriverTests
{
    private readonly Mock<IGenerator> generator = new();
    private readonly Mock<IFormatter> formatter = new();
    private readonly Mock<ICollector> collector = new();

    [Fact]
    public void FailsFast()
    {
        this.generator.Setup(e => e.GetRange()).Throws<InvalidOperationException>();
        var sut = GetSut();
        Assert.Throws<InvalidOperationException>(() => sut.Execute());
    }

    private Driver GetSut()
    {
        return new Driver(
            generator.Object,
            formatter.Object,
            collector.Object);
    }
}