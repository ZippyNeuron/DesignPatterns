namespace DesignPatterns.State;

public class StateMiddleAged : ITimeOfLifeState
{
    public StateMiddleAged()
    {
        Console.WriteLine("-> StateMiddleAged");
    }
    
    public void SmokeAndDrink()
    {
        Console.WriteLine("SmokeAndDrink :: Maybe just the one!");
    }

    public void Clubbing()
    {
        Console.WriteLine("Clubbing :: Dancing like ma Dad!");
    }

    public void Sleeping()
    {
        Console.WriteLine("Sleeping :: Is it that time already?");
    }
}