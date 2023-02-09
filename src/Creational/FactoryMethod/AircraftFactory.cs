namespace FactoryMethod;

public abstract class AircraftFactory
{
    public virtual IAircraft Create()
    {
        return new AircraftMicrolight();
    }
}