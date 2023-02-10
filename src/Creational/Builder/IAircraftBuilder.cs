namespace DesignPatterns.Builder;

public interface IAircraftBuilder
{
    public IAircraftBuilder AddEngine(int engineNumber, EnginePosition enginePosition);
    public IAircraftBuilder AddGear(bool retractable);
    public IAircraftBuilder AddAutopilot();
    public IAircraft Build();
    public IAircraftBuilder Reset();
}