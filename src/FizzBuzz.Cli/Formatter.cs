namespace FizzBuzz.Cli
{
    public class Formatter(int i)
    {
        public string FormatWithRules()
        {
            string? line;
            if (i % 3 == 0 && i % 5 == 0)
            {
                var fizzbuzz = "FizzBuzz";
                line = fizzbuzz;
            }
            else if (i % 3 == 0)
            {
                var fizz = "Fizz";
                line = fizz;
            }
            else if (i % 5 == 0)
            {
                var buzz = "Buzz";
                line = buzz;
            }
            else
            {
                line = i.ToString();
            }
            string s = line;
            return s;
        }
    }
}
