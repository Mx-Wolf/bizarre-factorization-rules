namespace FizzBuzz.Cli
{
    public class Generator(int start, int count, Formatter formatter)
    {

        public IEnumerable<string> AllLines()
        {
            return Enumerable.Range(start, count).Select(formatter.FormatWithRules);
        }
    }
}
