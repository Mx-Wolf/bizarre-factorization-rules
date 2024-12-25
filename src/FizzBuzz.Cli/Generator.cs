public  class Generator(int lo, int hi)
{
    public IEnumerable<int> GetSequence()
    {
        return Enumerable.Range(lo,hi-lo+1);
    }
}