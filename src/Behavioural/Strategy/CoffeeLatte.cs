namespace DesignPatterns.Strategy;

public class CoffeeLatte : ICoffee
{
    public decimal Get()
    {
        return 2.86m;
    }
}