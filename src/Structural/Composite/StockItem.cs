namespace DesignPatterns.Composite;

public abstract class StockItem : IStockItem
{
    protected StockItem(string name, decimal price)
    {
        Price = price;
        Name = name;
    }

    public string Name { get; }
    public decimal Price { get; }

    public abstract decimal Total();
}