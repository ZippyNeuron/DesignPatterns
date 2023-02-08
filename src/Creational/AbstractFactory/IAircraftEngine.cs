namespace AbstractFactory;

public interface IAircraftEngine
{
    public void Start();
    public void Stop();
    public void Fail();
}