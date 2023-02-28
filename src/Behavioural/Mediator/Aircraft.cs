namespace DesignPatterns.Mediator;

public class Aircraft
{
    private readonly Random _random = new(Guid.NewGuid().GetHashCode());
    private readonly IController _controller;
    
    public Aircraft(string name, IController controller)
    {
        Name = name;
        _controller = controller;
    }

    public async Task<bool> TakeOffAsync()
    {
        var wait = _random.Next(3000);
        
        await Task.Delay(wait);
        
        while (!_controller.RequestTakeOff(this))
        {
            await Task.Delay(20);
        }

        _controller.ReportTakeOff(this);

        return true;
    }
    
    public readonly string Name;
}