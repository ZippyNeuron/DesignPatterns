namespace DesignPatterns.Command;

public class CommandCoffee : Command
{
    public CommandCoffee(Barista barista) : base(barista) {}
    
    public override void Execute() => Barista.MakeCoffee();
}