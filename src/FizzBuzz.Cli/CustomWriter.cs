namespace FizzBuzz.Cli
{
    class CustomWriter(TextWriter writer) : TextWriter
    {
        private static readonly Random rnd = new Random(23);
        public override void WriteLine(string? value)
        {
            if (value == "FizzBuzz" && rnd.Next(100)<70)
            {
                throw new ArgumentException("Exception occurred: 'FizzBuzz' is not allowed.", nameof(value));
            }

            writer.WriteLine(value);
        }

        public override void WriteLine(int value)
        {
            writer.WriteLine(value);
        }

        public override System.Text.Encoding Encoding => writer.Encoding;
    }
}
