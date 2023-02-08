namespace AbstractFactory;

public interface IAircraftBuilder
{
    public IAircraftBuilder AddEngines(EnginePosition enginePosition, int count);
}