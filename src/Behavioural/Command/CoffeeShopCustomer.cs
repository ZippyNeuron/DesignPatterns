namespace DesignPatterns.Command;

public class CoffeeShopCustomer
{
    private readonly Command _commandTea;
    private readonly Command _commandCoffee;

    public CoffeeShopCustomer(Command commandTea, Command commandCoffee)
    {
        _commandTea = commandTea;
        _commandCoffee = commandCoffee;
    }

    public void TeaPlease() => _commandTea.Execute();
    public void CoffeePlease() => _commandCoffee.Execute();
}