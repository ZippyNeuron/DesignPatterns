namespace DesignPatterns.Momento;

public class MomentoStore
{
    private readonly Stack<IMomento> _momentos = new();

    public void Store(IMomento momento)
    {
        _momentos.Push(momento);
    }
    
    public IMomento Fetch()
    {
        return _momentos.Pop();
    }
}