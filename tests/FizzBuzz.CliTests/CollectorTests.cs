using AutoFixture;
using FizzBuzz.Cli;
using Moq;

namespace FizzBuzz.CliTests;

public class CollectorTests
{
    private readonly Mock<TextWriter> writer = new();
    private readonly Fixture fix = new ();
    [Fact]
    public void SeparatesItemsWithNewLine()
    {
        var line = this.fix.Create<string>();
        var sut = GetSut();
        sut.Collect(line);
        writer.Verify(e => e.WriteLine(line), Times.Once);
    }

    private Collector GetSut()
    {
        return new Collector(this.writer.Object);
    }
}