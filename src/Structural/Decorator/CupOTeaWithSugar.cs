namespace DesignPatterns.Decorator;

public class CupOTeaWithSugar : ICupOTea
{
    private readonly ICupOTea _cupOTea;
    
    public CupOTeaWithSugar(ICupOTea cupOTea)
    {
        _cupOTea = cupOTea;
    }

    public void Make()
    {
        _cupOTea.Make();
        Console.WriteLine("Adding some sugar");
    }
}