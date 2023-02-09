namespace FactoryMethod;

public class AircraftPropellerFactory : AircraftFactory
{
    public override IAircraft Create()
    {
        return new AircraftPropeller();
    }
}