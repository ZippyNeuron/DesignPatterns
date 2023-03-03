namespace DesignPatterns.State;

public class StateYoung : ITimeOfLifeState
{
    public StateYoung()
    {
        Console.WriteLine("-> StateYoung");
    }
    
    public void SmokeAndDrink()
    {
        Console.WriteLine("SmokeAndDrink :: Let's do this!");
    }

    public void Clubbing()
    {
        Console.WriteLine("Clubbing :: Yea boi!!");
    }

    public void Sleeping()
    {
        Console.WriteLine("Sleeping :: Say what?");
    }
}