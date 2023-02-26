namespace DesignPatterns.Command;

public abstract class Command
{
    protected readonly Barista Barista;

    protected Command(Barista barista)
    {
        Barista = barista;
    }

    public abstract void Execute();
}