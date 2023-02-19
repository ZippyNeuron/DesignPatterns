namespace DesignPatterns.Composite;

public interface IStockItem
{
    public string Name { get; }
    public decimal Price { get; }

    public decimal Total();
}