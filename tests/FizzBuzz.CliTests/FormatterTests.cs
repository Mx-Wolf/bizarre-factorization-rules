using FizzBuzz.Cli;

namespace FizzBuzz.CliTests;

public class FormatterTests
{
    private int i = 0;
    [Fact]
    public void MakesFizz()
    {
        i = 3;
        var sut = GetSut();
        var result = sut.FormatWithRules();
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void MakesBuzz()
    {
        i = 5;
        var sut = GetSut();
        var result = sut.FormatWithRules();
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void MakesFizzBuzz()
    {
        i = 15;
        var sut = GetSut();
        var result = sut.FormatWithRules();
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void MakesDigits()
    {
        i = 16;
        var sut = GetSut();
        var result = sut.FormatWithRules();
        Assert.Equal("16", result);
    }

    private Formatter GetSut()
    {
        return new Formatter(i, new Rules(i));
    }
}