using AutoFixture;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests;

public class RulesTests
{
    private Mock<IOptions<RulesSettings>> options = new();
    private readonly Fixture fix = new();

    public RulesTests()
    {
        fix.Customize<RulesSettings>(e => e.With(x => x.Larger, 5).With(x => x.Smaller, 3));
    }
    [Theory]
    [InlineData(3,true)]
    [InlineData(5,false)]
    public void RuleSmallerMultipleOfSmaller(int i, bool expected)
    {
        var settings = fix.Create<RulesSettings>();
        options.Setup(e => e.Value).Returns(settings);
        var sut = GetSut();
        var result = sut.IsSmaller(i);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(3, false)]
    [InlineData(5, true)]
    public void RuleLargeMultipleOfLarge(int i, bool expected)
    {
        var settings = fix.Create<RulesSettings>();
        options.Setup(e => e.Value).Returns(settings);
        var sut = GetSut();
        var result = sut.IsLarger(i);
        Assert.Equal(expected, result);
    }

    private Rules GetSut()
    {
        return new Rules(options.Object);
    }
}