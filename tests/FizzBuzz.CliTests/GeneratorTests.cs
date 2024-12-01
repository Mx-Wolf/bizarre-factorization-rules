using FizzBuzz.Cli;

namespace FizzBuzz.CliTests
{
    public class GeneratorTests
    {
        private int start = 1;
        private int count = 100;
        [Fact]
        public void ProducesCountItems()
        {
            count = 10;
            var sut = GetSut();
            Assert.Equal(count, sut.AllLines().Count());
        }

        private Generator GetSut()
        {
            return new Generator(start, count);
        }
    }
}
