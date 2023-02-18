namespace DesignPatterns.Bridge;

public class SimulatorEngineOld : ISimulatorEngine
{
    public void Prime()
    {
        Console.WriteLine("This engine type cannot be primed.");
    }
    
    public void Start()
    {
        Console.WriteLine("Simulator Engine Started : v1.0");
    }
}