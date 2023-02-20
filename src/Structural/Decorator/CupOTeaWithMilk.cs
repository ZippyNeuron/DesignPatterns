namespace DesignPatterns.Decorator;

public class CupOTeaWithMilk : ICupOTea
{
    private readonly ICupOTea _cupOTea;
    public CupOTeaWithMilk(ICupOTea cupOTea)
    {
        _cupOTea = cupOTea;
    }

    public void Make()
    {
        _cupOTea.Make();
        Console.WriteLine("Adding some milk");
    }
}