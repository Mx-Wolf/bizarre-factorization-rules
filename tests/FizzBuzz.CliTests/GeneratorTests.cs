namespace FizzBuzz.CliTests
{
    public class GeneratorTests
    {
        [Theory]
        [InlineData(1,100,100)]
        public void GeneratorCount(int lo, int hi, int count)
        {
            var sut = GetSut(lo, hi);
            var resultCount = sut.GetSequence().Count();
            Assert.Equal(count, resultCount);
        }

        private static Generator GetSut(int lo, int hi)
        {
            return new Generator(lo, hi);
        }
    }
}
