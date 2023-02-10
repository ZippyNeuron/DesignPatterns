namespace DesignPatterns.Builder;

public class AircraftBuilderDirector
{
    private readonly IAircraftBuilder _aircraftBuilder;
    
    public AircraftBuilderDirector(IAircraftBuilder aircraftBuilder)
    {
        _aircraftBuilder = aircraftBuilder;
    }

    public void BuildFourEngineJet()
    {
        _aircraftBuilder
            .AddGear(true)
            .AddEngine(1, EnginePosition.Left)
            .AddEngine(2, EnginePosition.Right)
            .AddEngine(3, EnginePosition.Left)
            .AddEngine(4, EnginePosition.Right)
            .AddAutopilot();
    }
    
    public void BuildTwoEngineJet()
    {
        _aircraftBuilder
            .AddGear(true)
            .AddEngine(1, EnginePosition.Left)
            .AddEngine(2, EnginePosition.Right)
            .AddAutopilot();
    }
    
    public void BuildSingleEngineProp()
    {
        _aircraftBuilder
            .AddGear(false)
            .AddEngine(1, EnginePosition.Front);
    }
}