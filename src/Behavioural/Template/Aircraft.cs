namespace DesignPatterns.Template;

public abstract class Aircraft
{
    protected readonly string TailNumber;
    protected readonly string AircraftType;
    
    protected Aircraft(string tailNumber, string aircraftType)
    {
        TailNumber = tailNumber;
        AircraftType = aircraftType;
    }

    public void FileFlightPlan()
    {
        Console.WriteLine($"Flight Plan : {TailNumber} ({AircraftType})");
    }
    
    public abstract void StartEngines();

    public void TakeOff()
    {
        Console.WriteLine($"The aircraft {TailNumber} is taking off");
    }
    
    public abstract void Gear(bool down);
    
    public void Land()
    {
        Console.WriteLine($"The aircraft {TailNumber} is landing");
    }
    
    public abstract void StopEngines();
}