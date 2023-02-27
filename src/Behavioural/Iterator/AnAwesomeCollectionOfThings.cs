namespace DesignPatterns.Iterator;

public class AnAwesomeCollectionOfThings<T> : ISuperCollection<T>
{
    private readonly LinkedList<T> _items;
    private readonly ICollectionIterator<T> _iterator;
    
    public AnAwesomeCollectionOfThings()
    {
        _items = new LinkedList<T>();
        _iterator = new CollectionIterator<T>(_items);
    }
    
    public void Add(T item)
    {
        _items.AddLast(item);
    }

    public ICollectionIterator<T> GetIterator()
    {
        return _iterator;
    }

    public int Count => _items.Count;
}