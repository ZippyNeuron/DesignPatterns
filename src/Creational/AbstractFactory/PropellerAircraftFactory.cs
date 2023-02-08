namespace AbstractFactory;

public class PropellerAircraftFactory : IAircraftFactory
{
    public IAircraftEngine CreateEngine(EnginePosition enginePosition)
    {
        return new PropellerAircraftEngine();
    }
}