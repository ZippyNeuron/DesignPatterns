namespace DesignPatterns.Mediator;

public class Controller : IController
{
    private Aircraft? _vehicleOnRunway;
    private readonly object _singleChannelRadio = new();

    public bool RequestTakeOff(Aircraft aircraft)
    {
        lock (_singleChannelRadio)
        {
            if (_vehicleOnRunway is not null)
            {
                return false;
            }
            
            _vehicleOnRunway = aircraft;
            
            return true;
        }
    }
    
    public void ReportTakeOff(Aircraft aircraft)
    {
        lock (_singleChannelRadio)
        {
            _vehicleOnRunway = (_vehicleOnRunway == aircraft) ? null : _vehicleOnRunway;

            if (_vehicleOnRunway is not null)
            {
                return;
            }

            Console.WriteLine($"{aircraft.Name} is in the air!");
        }
    }
}