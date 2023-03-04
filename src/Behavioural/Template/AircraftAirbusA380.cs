namespace DesignPatterns.Template;

public class AircraftAirbusA380 : Aircraft
{
    public AircraftAirbusA380(string tailNumber, string aircraftType) : base(tailNumber, aircraftType)
    {
    }
    
    public override void StartEngines()
    {
        Console.WriteLine($"The aircraft {TailNumber} is starting engine one");
        Console.WriteLine($"The aircraft {TailNumber} is starting engine two");
        Console.WriteLine($"The aircraft {TailNumber} is starting engine three");
        Console.WriteLine($"The aircraft {TailNumber} is starting engine four");
    }

    public override void Gear(bool down)
    {
        Console.WriteLine($"The aircraft {TailNumber} is {(down ? "lowering" : "raising")} its gear");
    }

    public override void StopEngines()
    {
        Console.WriteLine($"The aircraft {TailNumber} is stopping engine one");
        Console.WriteLine($"The aircraft {TailNumber} is stopping engine two");
        Console.WriteLine($"The aircraft {TailNumber} is stopping engine three");
        Console.WriteLine($"The aircraft {TailNumber} is stopping engine four");
    }
}