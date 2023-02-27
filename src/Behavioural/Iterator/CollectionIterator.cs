namespace DesignPatterns.Iterator;

public class CollectionIterator<T> : ICollectionIterator<T>
{
    private readonly LinkedList<T> _list;
    private LinkedListNode<T>? _current;
    
    public CollectionIterator(LinkedList<T> list)
    {
        _list = list;
    }
    
    public T? Next()
    {
        _current = (_current is null) ? _list.First : _current.Next;
        return _current!.Value;
    }

    public bool HasMoreItems()
    {
        return (_current != _list.Last);
    }
}