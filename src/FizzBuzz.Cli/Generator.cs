namespace FizzBuzz.Cli
{
    public class Generator(int start, int count)
    {
        private readonly Rules rules = new Rules();

        public IEnumerable<string> AllLines()
        {
            return Enumerable.Range(start, count).Select((i) => new Formatter(rules, new Factory()).FormatWithRules(i));
        }
    }
}
