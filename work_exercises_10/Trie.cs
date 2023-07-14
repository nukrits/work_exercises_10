internal class Trie
{
    private IEnumerable<string> stringArray;

    public Trie(IEnumerable<string> stringArray)
    {
        this.stringArray = stringArray;
    }

    internal bool MatchesPrefix(string v)
    {
        throw new NotImplementedException();
    }
}