namespace AbstractFactory;

public interface IAircraft
{
    public IEnumerable<IAircraftEngine> Engines { get; set; }
}