namespace DesignPatterns.State;

public class StateOld : ITimeOfLifeState
{
    public StateOld()
    {
        Console.WriteLine("-> StateOld");
    }
    
    public void SmokeAndDrink()
    {
        Console.WriteLine("SmokeAndDrink :: That sheeet'll kill ya!");
    }

    public void Clubbing()
    {
        Console.WriteLine("Clubbing :: Who needs clubbing?");
    }

    public void Sleeping()
    {
        Console.WriteLine("Sleeping :: Already there!");
    }
}