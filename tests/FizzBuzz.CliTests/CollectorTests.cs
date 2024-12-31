using AutoFixture;
using FizzBuzz.Cli;
using Microsoft.Extensions.Logging;
using Moq;

namespace FizzBuzz.CliTests;

public class CollectorTests
{
    private readonly Mock<TextWriter> writer = new();
    private readonly Mock<ILogger<Collector>> logger = new();
    private readonly Fixture fix = new Fixture();
    [Fact]
    public void SeparatesItemsWithNewLine()
    {
        var line = this.fix.Create<string>();
        var sut = GetSut();
        sut.Collect(line);
        writer.Verify((e) => e.WriteLine(line), Times.Once);
    }

    private Collector GetSut()
    {
        return new Collector(this.logger.Object, Console.Out, this.writer.Object);
    }
}