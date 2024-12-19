using FizzBuzz.Cli;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests;

public class FormatterTests
{
    private readonly Mock<IRules> rules = new();
    private readonly Mock<IOptions<WordSettings>> wordSettings = new();
    private int i = 0;
    [Fact]
    public void MakesFizz()
    {
        i = 3;
        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void MakesBuzz()
    {
        i = 5;
        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void MakesFizzBuzz()
    {
        i = 15;
        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void MakesDigits()
    {
        i = 16;
        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal("16", result);
    }

    private Formatter GetSut()
    {
        return new Formatter(this.rules.Object, this.wordSettings.Object);
    }
}