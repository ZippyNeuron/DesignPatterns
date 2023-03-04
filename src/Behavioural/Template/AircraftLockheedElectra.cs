namespace DesignPatterns.Template;

public class AircraftLockheedElectra : Aircraft
{
    public AircraftLockheedElectra(string tailNumber, string aircraftType) : base(tailNumber, aircraftType)
    {
    }

    public override void StartEngines()
    {
        Console.WriteLine($"The aircraft {TailNumber} is starting its left engine");
        Console.WriteLine($"The aircraft {TailNumber} is starting its right engine");
    }

    public override void Gear(bool down)
    {
        Console.WriteLine($"The aircraft {TailNumber} is {(down ? "lowering" : "raising")} its gear");
    }

    public override void StopEngines()
    {
        Console.WriteLine($"The aircraft {TailNumber} is shutting down its left engine");
        Console.WriteLine($"The aircraft {TailNumber} is shutting down its right engine");
    }
}