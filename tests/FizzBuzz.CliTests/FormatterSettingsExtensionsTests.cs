using AutoFixture;
using FizzBuzz.Cli;
using FizzBuzz.Formatter.Divisibility;

namespace FizzBuzz.CliTests
{
    public class FormatterSettingsExtensionsTests
    {
        private readonly Fixture fix = new();
        [Fact]
        public void BothDivisorsConvention()
        {
            var settings = fix.Create<FormatterSettings>();
            var result = settings.FizzBuzz();
            Assert.StartsWith(settings.Fizz, result);
            Assert.EndsWith(settings.Buzz,result);
        }
    }
}
