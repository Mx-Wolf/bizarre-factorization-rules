namespace FizzBuzz.Cli;

public  class Generator(int lo, int hi) : IGenerator
{
    public IEnumerable<int> GetSequence() => Enumerable.Range(lo,hi-lo+1);
}