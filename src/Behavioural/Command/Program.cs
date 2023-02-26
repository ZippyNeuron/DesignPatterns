using DesignPatterns.Command;

var barista = new Barista();

var coffeeShopCustomer = new CoffeeShopCustomer(
    new CommandTea(barista), 
    new CommandCoffee(barista));

coffeeShopCustomer.TeaPlease();
coffeeShopCustomer.CoffeePlease();