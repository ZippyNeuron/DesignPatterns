namespace DesignPatterns.Iterator;

public interface ICollectionIterator<out T>
{
    public T? Next();
    public bool HasMoreItems();
}