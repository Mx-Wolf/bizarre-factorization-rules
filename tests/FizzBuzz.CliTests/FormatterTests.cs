using System.Globalization;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;

namespace FizzBuzz.CliTests
{
    public class FormatterTests
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FormattingKnownRules(int i, string expected)
        {
            var sut = GetSut();
            var result = sut.Format(i);
            Assert.Equal(expected, result);
        }

        private Formatter GetSut()
        {
            return new Formatter(CultureInfo.InvariantCulture, new OptionsWrapper<FormatterSettings>(new FormatterSettings()
            {
                Larger = "Buzz",
                Smaller = "Fizz"
            }), new Rules(new OptionsWrapper<RulesSettings>(new RulesSettings(){Smaller = 3, Larger = 5})));
        }
    }
}
