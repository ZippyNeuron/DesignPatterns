namespace DesignPatterns.Command;

public class Barista
{
    public void MakeTea() => Console.WriteLine("-> The barista has made the tea");
    public void MakeCoffee() => Console.WriteLine("-> The barista has made the coffee");
}