using FizzBuzz.Cli;

namespace FizzBuzz.CliTests
{
    public class FactoryTests
    {
        [Fact]
        public void SameInstanceFizzBuzz()
        {
            var sut = GetSut();
            var a = sut.FizzBuzz();
            var b = sut.FizzBuzz();
            Assert.Same(a,b);
        }

        [Fact]
        public void SameInstanceFizz()
        {
            var sut = GetSut();
            var a = sut.Fizz();
            var b = sut.Fizz();
            Assert.Same(a, b);
        }
        [Fact]
        public void SameInstanceBuzz()
        {
            var sut = GetSut();
            var a = sut.Buzz();
            var b = sut.Buzz();
            Assert.Same(a, b);
        }

        private Factory GetSut()
        {
            return new Factory();
        }
    }
}
