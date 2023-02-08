namespace AbstractFactory;

public class JetAircraftFactory : IAircraftFactory
{
    public IAircraftEngine CreateEngine(EnginePosition enginePosition)
    {
        return new JetAircraftEngine();
    }
}