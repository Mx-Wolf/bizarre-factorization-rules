using AutoFixture;
using FizzBuzz.Cli;
using FizzBuzz.Formatter.Divisibility;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests
{
public class RulesTests
{
        private readonly Mock<IOptions<RulesSettings>> options = new();
    private readonly Fixture fix = new();

        [Fact]
        public void KnownLargerDivisibility()
    {
            var settings = fix.Create<RulesSettings>();
            options.Setup(e => e.Value).Returns(settings);
            var ix = fix.Create<int>() * settings.LargerDivisor;
            var sut = GetSut();
            var result = sut.MultipleToLargeDivisor(ix);
            Assert.True(result);
    }
        [Fact]
        public void KnownLargerInDivisibility()
    {
        var settings = fix.Create<RulesSettings>();
        options.Setup(e => e.Value).Returns(settings);
            var ix = fix.Create<int>() * settings.LargerDivisor +1;
        var sut = GetSut();
            var result = sut.MultipleToLargeDivisor(ix);
            Assert.False(result);
        }
        [Fact]
        public void KnownSmallerDivisibility()
        {
            var settings = fix.Create<RulesSettings>();
            options.Setup(e => e.Value).Returns(settings);
            var ix = fix.Create<int>() * settings.SmallerDivisor;
            var sut = GetSut();
            var result = sut.MultipleToSmallDivisor(ix);
            Assert.True(result);
    }
        [Fact]
        public void KnownSmallerInDivisibility()
    {
        var settings = fix.Create<RulesSettings>();
        options.Setup(e => e.Value).Returns(settings);
            var ix = fix.Create<int>() * settings.SmallerDivisor + 1;
            var sut = GetSut();
            var result = sut.MultipleToSmallDivisor(ix);
            Assert.False(result);
        }

        [Fact]
        public void ThrowsOnZeroSettingForSmaller()
        {
            var settings = fix.Build<RulesSettings>()
                .With(e => e.SmallerDivisor, 0)
                .Create();
            options.Setup(e => e.Value).Returns(settings);
            var sut = GetSut();
            Assert.Throws<DivideByZeroException>(() => sut.MultipleToSmallDivisor(1));
        }
        [Fact]
        public void ThrowsOnZeroSettingForLarger()
        {
            var settings = fix.Build<RulesSettings>()
                .With(e => e.LargerDivisor, 0)
                .Create();
            options.Setup(e => e.Value).Returns(settings);
        var sut = GetSut();
            Assert.Throws<DivideByZeroException>(() => sut.MultipleToLargeDivisor(1));
    }

    private Rules GetSut()
    {
        return new Rules(options.Object);
    }
}
}
