namespace DesignPatterns.Iterator;

public interface ISuperCollection<in T>
{
    public void Add(T item);
}