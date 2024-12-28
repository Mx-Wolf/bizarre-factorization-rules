Console.WriteLine(string.Join(
    Environment.NewLine,
    Enumerable.Range(1, 100).Select(
        x => (x % 3, x % 5) switch
        {
            (0, 0) => "FizzBuzz",
            (0, _) => "Fizz",
            (_, 0) => "Buzz",
            _ => x.ToString()
        })));
