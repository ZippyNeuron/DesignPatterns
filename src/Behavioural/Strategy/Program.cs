
using DesignPatterns.Strategy;

var mrCoffee1 = new MrCoffee(new CoffeeBlack());
Console.WriteLine($"You were charged {mrCoffee1.PushButton()} for a black coffee");

var mrCoffee2 = new MrCoffee(new CoffeeLatte());
Console.WriteLine($"You were charged {mrCoffee2.PushButton()} for a latte");

var mrCoffee3 = new MrCoffee(new CoffeeCappuccino());
Console.WriteLine($"You were charged {mrCoffee3.PushButton()} for a cappuccino");
