namespace AbstractFactory;

public interface IAircraftFactory
{
    public IAircraftEngine CreateEngine(EnginePosition enginePosition);
}