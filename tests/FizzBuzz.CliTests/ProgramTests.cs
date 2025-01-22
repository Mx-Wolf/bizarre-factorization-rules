namespace FizzBuzz.CliTests
{
    public class ProgramTests
    {
        [Fact]
        public void MainOutput100Lines()
        {
            var result = ResultHelper();
            var count = result.Count(e => e == '\n');
            Assert.Equal(100, count);
        }

        [Fact]
        public void MainOutputs27Fizz()
        {
            var result = ResultHelper();
            var lines = result.Split('\n');
            var count = lines.Count(e => e.Trim() == "Fizz");
            Assert.Equal(27, count);
        }
        [Fact]
        public void MainOutputs14Fizz()
        {
            var result = ResultHelper();
            var lines = result.Split('\n');
            var count = lines.Count(e => e.Trim() == "Buzz");
            Assert.Equal(14, count);
        }
        [Fact]
        public void MainOutputs6FizzBuzz()
        {
            var result = ResultHelper();
            var lines = result.Split('\n');
            var count = lines.Count(e => e.Trim() == "FizzBuzz");
            Assert.Equal(6, count);
        }

        private static string ResultHelper()
        {
            string result;
            var c = Console.Out;
            try
            {
                using var sw = new StringWriter();
                Console.SetOut(sw);
                Program.Main([]);
                result = sw.ToString();

            }
            finally
            {
                Console.SetOut(c);
            }

            return result;
        }
    }
}
