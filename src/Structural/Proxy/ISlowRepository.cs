namespace DesignPatterns.Proxy;

public interface ISlowRepository
{
    public IEnumerable<SlowRepositoryItem> GetItems();
}