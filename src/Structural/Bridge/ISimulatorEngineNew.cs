namespace DesignPatterns.Bridge;

public class SimulatorEngineNew : ISimulatorEngine
{
    public void Prime()
    {
        Console.WriteLine("Simulator Engine Primed : v2.0");
    }
    
    public void Start()
    {
        Console.WriteLine("Simulator Engine Started : v2.0");
    }
}