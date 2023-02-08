namespace AbstractFactory;

public class AircraftBuilder : IAircraftBuilder
{
    private readonly IAircraftFactory _aircraftFactory;
    private readonly IList<IAircraftEngine> _aircraftEngines = new List<IAircraftEngine>();
    
    public AircraftBuilder(IAircraftFactory aircraftFactory)
    {
        _ = aircraftFactory ?? throw new ArgumentNullException(nameof(aircraftFactory));
        
        _aircraftFactory = aircraftFactory;
    }

    public IAircraftBuilder AddEngines(EnginePosition enginePosition, int count)
    {
        for (var i = 0; i < count; i++)
        {
            _aircraftEngines.Add(_aircraftFactory.CreateEngine(enginePosition));
        }

        return this;
    }
}