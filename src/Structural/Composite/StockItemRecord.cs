namespace DesignPatterns.Composite;

public class StockItemRecord : StockItem
{
    private readonly IList<StockItemRecord> _stockItemRecords;

    public StockItemRecord(string name) : base(name, 0m)
    {
        _stockItemRecords = new List<StockItemRecord>();
    }
    
    public StockItemRecord(string name, decimal price) : base(name, price)
    {
        _stockItemRecords = new List<StockItemRecord>();
    }

    public StockItemRecord Add(StockItemRecord stockItemRecord)
    {
        _stockItemRecords.Add(stockItemRecord);
        return stockItemRecord;
    }
    
    public override decimal Total()
    {
        return Price + _stockItemRecords.Sum(stockItem => stockItem.Total());
    }
}