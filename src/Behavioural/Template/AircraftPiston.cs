namespace DesignPatterns.Template;

public class AircraftPiston : Aircraft
{
    public AircraftPiston(string tailNumber, string aircraftType) : base(tailNumber, aircraftType)
    {
    }

    public override void StartEngines()
    {
        Console.WriteLine($"The aircraft {TailNumber} is starting its single engine");
    }

    public override void Gear(bool down)
    {
        Console.WriteLine($"The aircraft {TailNumber} does not have retractable landing gear");
    }

    public override void StopEngines()
    {
        Console.WriteLine($"The aircraft {TailNumber} is stopping its single engine");
    }
}