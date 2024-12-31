using System.ComponentModel.DataAnnotations;
using AutoFixture;
using AutoFixture.Xunit2;
using FizzBuzz.Cli;
using Moq;

namespace FizzBuzz.CliTests
{
public class DriverTests
{
    private readonly Mock<IGenerator> generator = new();
    private readonly Mock<IFormatter> formatter = new();
    private readonly Mock<ICollector> collector = new();
        private readonly Fixture fix = new();
        [Theory]
        [AutoData]
        public void DriverUsesServices([Range(3,200)] int count)
        {

            var sequence = fix.CreateMany<int>(count);
            var line = fix.Create<string>();
            generator.Setup(e => e.GetRange()).Returns(sequence);
            formatter.Setup(e => e.Format(It.IsAny<int>())).Returns(line);

        var sut = GetSut();

            sut.Execute();

            generator.Verify(e=>e.GetRange(),Times.Once);
            formatter.Verify(e=>e.Format(It.IsAny<int>()),Times.Exactly(count));
            collector.Verify(e=>e.Collect(It.IsAny<string>()),Times.Exactly(count));
    }

    private Driver GetSut()
    {
        return new Driver(
            generator.Object,
            formatter.Object,
            collector.Object);
    }
}
}
