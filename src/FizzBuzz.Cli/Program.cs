// See https://aka.ms/new-console-template for more information
for (var i = 1; i <= 100; i++)
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
    string result = line;
    Console.WriteLine(result);
    
}
