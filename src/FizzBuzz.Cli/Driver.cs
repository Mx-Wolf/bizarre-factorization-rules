namespace FizzBuzz.Cli
{
    internal class Driver : IDriver
    {
        private readonly IFormatter _formatter;

        public Driver(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public void Execute()
        {
            for (var i = 1; i <= 100; i++)
            {
                var line = _formatter.Format(i);
                Console.WriteLine(line);
            }
        }
    }
}
