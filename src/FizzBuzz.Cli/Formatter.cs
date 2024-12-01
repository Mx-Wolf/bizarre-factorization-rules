namespace FizzBuzz.Cli
{
    public class Formatter(int i, Rules rules)
    {
        public string FormatWithRules()
        {
            string? line;
            if (new Rules(i).Rule3() && new Rules(i).Rule5())
            {
                var fizzbuzz = "FizzBuzz";
                line = fizzbuzz;
            }
            else if (new Rules(i).Rule3())
            {
                var fizz = "Fizz";
                line = fizz;
            }
            else if (new Rules(i).Rule5())
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
