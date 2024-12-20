// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine(
    Enumerable.Range(1, 100)
        .Select(x => (x % 3, x % 5) switch
        {
            (0, 0) => "FizzBuzz", 
            (0, _) => "Fizz", 
            (_, 0) => "Buzz", 
            _ => x.ToString()
        })
        .Aggregate(
            new StringBuilder(), 
            (a, b) =>
            {
                a.Append(b).Append(
                    Environment.NewLine); 
                return a;
            }));

