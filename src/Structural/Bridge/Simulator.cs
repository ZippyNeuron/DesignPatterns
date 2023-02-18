namespace DesignPatterns.Bridge;

public class Simulator
{
    private readonly ISimulatorEngine _simulatorEngine;

    public Simulator(ISimulatorEngine simulatorEngine)
    {
        _simulatorEngine = simulatorEngine;
    }

    public void StartTheSimulatorEngine()
    {
        Console.WriteLine("The simulator engine is starting.");

        _simulatorEngine.Prime();
        _simulatorEngine.Start();
    }
}