namespace DesignPatterns.Strategy;

public class MrCoffee
{
    private readonly ICoffee _coffee;
    
    public MrCoffee(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public decimal PushButton()
    {
        return _coffee.Get();
    }
}