namespace DesignPatterns.Proxy;

public class SlowRepository : ISlowRepository
{
    private readonly Random _rnd = new Random(Guid.NewGuid().GetHashCode());
    
    public IEnumerable<SlowRepositoryItem> GetItems()
    {
        const int noOfItems = 100;
        
        var items = new List<SlowRepositoryItem>();
        var msEach = _rnd.Next(1000, 3000) / noOfItems;
        var startTime = DateTime.Now;
        
        for (var i = 0; i < 100; i++)
        {
            items.Add(new SlowRepositoryItem() { Id = Guid.NewGuid() });
            Thread.Sleep(msEach);
        }
        
        Console.WriteLine($"Retrieved {noOfItems} items in {DateTime.Now.Subtract(startTime).TotalMilliseconds.ToString("N0")} milliseconds");
        
        return items;
    }
}