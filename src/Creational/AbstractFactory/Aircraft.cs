namespace AbstractFactory;

public class Aircraft : IAircraft
{
    public IEnumerable<IAircraftEngine> Engines { get; set; } = new List<IAircraftEngine>();
}