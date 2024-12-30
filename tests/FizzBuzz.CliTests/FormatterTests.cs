using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.Xunit2;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests
{
    public class FormatterTests
    {
        private readonly Mock<IOptions<FormatterSettings>> options = new();
        private readonly Mock<IRules> rules = new();
        private readonly Fixture fix = new();

        

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(false, false)]
        public void UsesInjectedServiceForRule(bool smaller, bool larger)
        {
            var settings = fix.Create<FormatterSettings>();
            options.Setup(e => e.Value).Returns(settings);
            rules.Setup(e => e.MultipleToSmallDivisor(It.IsAny<int>())).Returns(smaller);
            rules.Setup(e => e.MultipleToLargeDivisor(It.IsAny<int>())).Returns(larger);

            var i = fix.Create<int>();

            var sut = GetSut();
            sut.Format(i);

            rules.Verify(e => e.MultipleToSmallDivisor(It.IsAny<int>()), Times.Exactly(1));
            rules.Verify(e => e.MultipleToLargeDivisor(It.IsAny<int>()), Times.Exactly(1));
        }

        [Theory]
        [InlineData(true, true, "ab")]
        [InlineData(false, true, "b")]
        [InlineData(true, false, "a")]
        [InlineData(false, false, "16")]
        public void UsesSettingsWithRules(bool smaller, bool larger, string expected)
        {
            var settings = fix.Build<FormatterSettings>()
                .With(e => e.Fizz, "a")
                .With(e => e.Buzz, "b")
                .Create();
            options.Setup(e => e.Value).Returns(settings);
            rules.Setup(e => e.MultipleToLargeDivisor(It.IsAny<int>())).Returns(larger);
            rules.Setup(e => e.MultipleToSmallDivisor(It.IsAny<int>())).Returns(smaller);

            var i = 16;

            var sut = GetSut();

            var result = sut.Format(i);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CannotBeConstructedWithNullSetting()
        {

            Assert.Throws<NullReferenceException>(GetSut);
        }

        private Formatter GetSut()
        {
            return new Formatter(
                options.Object,
                rules.Object);
        }
    }
}
