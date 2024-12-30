using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using FizzBuzz.Cli;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests
{
    public class GeneratorTests
    {
        private readonly Fixture fix = new();
        private readonly Mock<IOptions<GeneratorSettings>> options = new();
        [Fact]
        public void FailsOnInvertedRange()
        {
            var settings = fix.Build<GeneratorSettings>()
                .With(e => e.LowerBoundary, 100)
                .With(e => e.UpperBoundary)
                .Create();
            options.Setup(e => e.Value).Returns(settings);
            var sut = GetSut();
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetRange());
        }

        private Generator GetSut()
        {
            return new Generator(options.Object);
        }
    }
}
