using AutoFixture;
using FizzBuzz.Application.TwoRules;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests;

public class FormatterTests
{
    private readonly Mock<IRules> rules = new();
    private readonly Mock<IOptions<WordSettings>> wordSettings = new();
    private readonly Fixture fix = new();
    private int i = 0;
    [Fact]
    public void MakesFizz()
    {
        i = 3;
        var settings = fix.Create<WordSettings>();
        rules.Setup(e => e.Rule3(i)).Returns(true);
        wordSettings.Setup(e => e.Value).Returns(settings);
        
        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal(settings.Fizz, result);
    }

    [Fact]
    public void MakesBuzz()
    {
        i = 5;
        var settings = fix.Create<WordSettings>();
        rules.Setup(e => e.Rule5(i)).Returns(true);
        wordSettings.Setup(e => e.Value).Returns(settings);

        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal(settings.Buzz, result);
    }

    [Fact]
    public void MakesFizzBuzz()
    {
        i = 15;
       
        var settings = fix.Create<WordSettings>();
        rules.Setup(e => e.Rule3(i)).Returns(true);
        rules.Setup(e => e.Rule5(i)).Returns(true);
        wordSettings.Setup(e => e.Value).Returns(settings);
        var sut = GetSut();
        var result = sut.FormatWithRules(i);
        Assert.Equal(settings.FizzBuzz, result);
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