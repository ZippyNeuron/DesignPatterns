namespace DesignPatterns.State;

public class Person
{
    public ITimeOfLifeState State { get; set; } = new StateYoung();
    
    public void SmokeAndDrink()
    {
        State.SmokeAndDrink();
    }

    public void Clubbing()
    {
        State.Clubbing();
    }

    public void Sleeping()
    {
        State.Sleeping();
    }
}