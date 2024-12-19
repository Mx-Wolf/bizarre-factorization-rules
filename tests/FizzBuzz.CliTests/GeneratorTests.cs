using FizzBuzz.Cli;

namespace FizzBuzz.CliTests
{
    public class GeneratorTests
    {
        private const int Start = 1;
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
            Rules rules = new Rules();
            return new Generator(Start, count, new Formatter( rules));
        }
    }
}
