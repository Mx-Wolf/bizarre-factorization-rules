using AutoFixture;
using FizzBuzz.Generator.IntegerSequence;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.Generator.IntegerSequenceTests;

public class GeneratorTests
{
    private readonly Fixture fix = new();
    private readonly Mock<IOptions<GeneratorSettings>> options = new();
    [Fact]
    public void FailsOnInvertedRange()
    {
        var settings = fix.Build<GeneratorSettings>()
            .With(e => e.LowerBoundary, 100)
            .With(e => e.UpperBoundary,1)
            .Create();
        options.Setup(e => e.Value).Returns(settings);
        var sut = GetSut();
        Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetRange());
    }

    private Generator.IntegerSequence.Generator GetSut()
    {
        return new Generator.IntegerSequence.Generator(options.Object);
    }
}