namespace FactoryMethod;

public class AircraftJetFactory : AircraftFactory
{
    public override IAircraft Create()
    {
        return new AircraftJet();
    }
}