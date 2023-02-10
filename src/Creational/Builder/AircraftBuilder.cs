namespace DesignPatterns.Builder;

public class AircraftBuilder : IAircraftBuilder
{
    private IAircraft _aircraft = new Aircraft();

    public IAircraftBuilder Reset()
    {
        _aircraft = new Aircraft();
        return this;
    }
    
    public IAircraftBuilder AddEngine(int engineNumber, EnginePosition enginePosition)
    {
        _aircraft.Engines.Add(new Engine() { Number = engineNumber, Position = enginePosition });
        return this;
    }

    public IAircraftBuilder AddGear(bool retractable)
    {
        _aircraft.HasGear = true;
        _aircraft.HasRetractableGear = retractable;
        return this;
    }

    public IAircraftBuilder AddAutopilot()
    {
        _aircraft.HasAutopilot = true;
        return this;
    }

    public IAircraft Build()
    {
        return _aircraft;
    }
}