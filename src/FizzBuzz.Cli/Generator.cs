namespace FizzBuzz.Cli
{
    public class Generator(int start, int count)
    {
        public IEnumerable<string> AllLines()
        {
            return Enumerable.Range(start, count).Select((i) => new Formatter(i, new Rules(i)).FormatWithRules());
        }
    }
}
