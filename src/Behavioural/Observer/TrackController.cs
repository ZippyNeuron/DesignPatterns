namespace DesignPatterns.Observer;

public class TrackController
{
    private readonly List<ITrain> _trains = new();
    
    public void AddTrain(ITrain train)
    {
        _trains.Add(train);
    }

    public void Go(ITrain train)
    {
        _trains.ForEach(t => t.Go(train == t));
    }
}