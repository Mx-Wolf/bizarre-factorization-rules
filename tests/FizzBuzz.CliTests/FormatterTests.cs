using System.Globalization;
using AutoFixture;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests
{
    public class FormatterTests
    {
        private readonly CultureInfo invariantCulture = CultureInfo.InvariantCulture;

        private readonly Mock<IOptions<FormatterSettings>> options = new();
        private readonly Fixture fix = new();

        private readonly Mock<IRules> rules = new();

        [Theory]
        [InlineData(true, false, "A1", "A2", "A1")]
        [InlineData(false, true, "B1", "B2", "B2")]
        [InlineData(true, true, "C1", "C2", "C1C2")]
        public void FormattingKnownRules(
            bool smallerRule, 
            bool largeRule,
            string smallerKey,
            string largerKey,
            string expected)
        {
            var setting = fix.Build<FormatterSettings>()
                .With(e => e.Larger, largerKey)
                .With(e => e.Smaller, smallerKey)
                .Create();
            var i = fix.Create<int>();
            options.Setup(e => e.Value).Returns(setting);
            rules.Setup(e => e.IsLarger(i)).Returns(largeRule);
            rules.Setup(e => e.IsSmaller(i)).Returns(smallerRule);

            var sut = GetSut();
            var result = sut.Format(i);
            Assert.Equal(expected, result);
        }

        private Formatter GetSut()
        {
            return new Formatter(invariantCulture, options.Object, rules.Object);
        }
    }
}
