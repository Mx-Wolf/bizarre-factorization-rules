using System.Globalization;
using FizzBuzz.Cli;

namespace FizzBuzz.CliTests
{
    public class FormatterTests
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        public void BasicFormattingRules(int i, string expected)
        {
            var sut = GetSut();
            var result = sut.Format(i);
            Assert.Equal(expected, result);
        }

        private Formatter GetSut()
        {
            return new Formatter(CultureInfo.InvariantCulture);
        }
    }
}
