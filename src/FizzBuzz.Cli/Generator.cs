public  class Generator(int lo, int hi) : IGenerator
{
    public IEnumerable<int> GetSequence()
    {
        return Enumerable.Range(lo,hi-lo+1);
    }
}