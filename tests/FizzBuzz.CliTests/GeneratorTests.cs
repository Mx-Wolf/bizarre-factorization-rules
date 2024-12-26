using FizzBuzz.Cli;
using Microsoft.Extensions.Options;

namespace FizzBuzz.CliTests;

public class GeneratorTests
{
    [Fact]
    public void CountsIncludeBoundaries()
    {
        var sut = GetSut();
        var count = sut.GetRange().Count();
        Assert.Equal(100, count);
    }

    private Generator GetSut()
    {
        return new Generator(new OptionsWrapper<GeneratorSettings>(new GeneratorSettings() { Hi = 100, Lo = 1 }));
    }
}