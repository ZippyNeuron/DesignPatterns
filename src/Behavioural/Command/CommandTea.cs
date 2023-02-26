namespace DesignPatterns.Command;

public class CommandTea : Command
{
    public CommandTea(Barista barista) : base(barista) {}

    public override void Execute() => Barista.MakeTea();
}