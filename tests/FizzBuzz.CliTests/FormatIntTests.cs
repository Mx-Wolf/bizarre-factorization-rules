using AutoFixture;
using FizzBuzz.Cli;

namespace FizzBuzz.CliTests
{
    public class FormatIntTests
    {
        private Fixture fix = new Fixture();
        [Fact]
        public void DecimalValue()
        {
            var x = fix.Create<int>();
            var sut = GetSut();
            var result = sut.Format(x);
            Assert.Equal(x.ToString("D"),result);
        }

        private FormatInt GetSut()
        {
            return new FormatInt();
        }
    }
}
