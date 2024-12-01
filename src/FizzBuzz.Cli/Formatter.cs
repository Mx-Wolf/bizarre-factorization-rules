namespace FizzBuzz.Cli
{
    public class Formatter(
        Rules rules,
        IFactory factory)
    {
        public string FormatWithRules(int x) => ChooseFormat(x).Format(x);

        private IFormatInt ChooseFormat(int x) => Rule3AndRule5(x) ? factory.FizzBuzz() : Rule5OrRule3(x);

        private bool Rule3AndRule5(int x) => rules.Rule3(x) && rules.Rule5(x);

        private IFormatInt Rule5OrRule3(int x) => rules.Rule3(x) ? factory.Fizz() : Rule5OrNone(x);

        private IFormatInt Rule5OrNone(int x) => rules.Rule5(x) ? factory.Buzz() : factory.None();
    }
}
