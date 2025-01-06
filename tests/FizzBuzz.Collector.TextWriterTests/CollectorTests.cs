using AutoFixture;
using Microsoft.Extensions.Logging;
using Moq;

namespace FizzBuzz.Collector.TextWriterTests;

public class CollectorTests
{
    private readonly Mock<System.IO.TextWriter> writer = new();
    private readonly Mock<ILogger<Collector.TextWriter.Collector>> logger = new();
    private readonly Fixture fix = new();
    [Fact]
    public void SeparatesItemsWithNewLine()
    {
        var line = this.fix.Create<string>();
        var sut = GetSut();
        sut.Collect(line);
        writer.Verify((e) => e.WriteLine(line), Times.Once);
    }

    private Collector.TextWriter.Collector GetSut()
    {
        return new Collector.TextWriter.Collector(this.logger.Object, this.writer.Object);
    }
}