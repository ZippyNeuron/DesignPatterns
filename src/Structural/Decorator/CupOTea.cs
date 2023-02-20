namespace DesignPatterns.Decorator;

public class CupOTea : ICupOTea
{
    public void Make()
    {
        Console.WriteLine("Making a cup-o-tea");
    }
}