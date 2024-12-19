using AutoFixture;
using FizzBuzz.Application;
using FizzBuzz.Application.TwoRules;
using FizzBuzz.Cli;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

namespace FizzBuzz.CliTests
{
    public class GeneratorTests
    {
        private readonly Mock<IOptions<GeneratorSettings>> generatorSettings = new();
        private readonly Mock<IFormatter> formatter = new();
        private readonly Mock<ILogger<Generator>> logger = new();
        private readonly Fixture fix = new();
        [Fact]
        public void ProducesCountItems()
        {
            var settings = this.fix.Create<GeneratorSettings>();
            generatorSettings.Setup(e => e.Value).Returns(settings);
            var sut = GetSut();
            Assert.Equal(settings.Count, sut.AllLines().Count());
        }

        private Generator GetSut()
        {
            return new Generator(
                this.generatorSettings.Object, 
                this.formatter.Object, 
                this.logger.Object);
        }
    }
}
