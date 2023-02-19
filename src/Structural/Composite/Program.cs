using DesignPatterns.Composite;

var stock = new StockItemRecord("Inventory", 0);

var area1 = stock.Add(new StockItemRecord("Area 1"));
    var drive1 = area1.Add(new StockItemRecord("Infinite Improbability Drive", 876221.12m));
    var drive2 = area1.Add(new StockItemRecord("Infinite Improbability Drive Components"));
        drive2.Add(new StockItemRecord("Used Circuitry", 8.52m));
        drive2.Add(new StockItemRecord("Wire", 1.02m));
        drive2.Add(new StockItemRecord("Hot Cup of Tea", 0.82m));

var area2 = stock.Add(new StockItemRecord("Area 2"));
    area2.Add(new StockItemRecord("Doritos", 3.00m));
    area2.Add(new StockItemRecord("Pepsi", 2.00m));

Console.WriteLine($"{area1.Name} Total: {area1.Total()}");
Console.WriteLine($"{drive1.Name} Total: {drive1.Total()}");
Console.WriteLine($"{drive2.Name} Total: {drive2.Total()}");
Console.WriteLine($"{area2.Name} Total: {area2.Total()}");