using FizzBuzz.Cli;

var textWriter = Console.Out;
var outFormatProvider = textWriter.FormatProvider;
var rules = new Rules();
var formatter = new Formatter(outFormatProvider, rules);
var generator = new Generator(1, 100);
var collector = new Collector(textWriter);
var driver = new Driver(generator, formatter, collector);
driver.Execute();