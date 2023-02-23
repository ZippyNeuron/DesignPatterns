namespace DesignPatterns.Proxy;

public class SlowRepositoryProxy : ISlowRepository
{
    private IList<SlowRepositoryItem>? _items;
    
    private readonly ISlowRepository _slowRepository = new SlowRepository();
    
    public IEnumerable<SlowRepositoryItem> GetItems()
    {
        if (string.IsNullOrWhiteSpace(Token))
        {
            throw new ApplicationException("The client is not authorised to access this method");
        }

        if (_items is not null)
        {
            Console.WriteLine($"Retrieved {_items.Count} items from cache");
        }
        
        return _items ??= _slowRepository.GetItems().ToList();
    }

    public string Token { get; set; } = string.Empty;
}