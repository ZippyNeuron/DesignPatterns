using DesignPatterns.Template;

var aircrafts = new List<Aircraft>()
{
    new AircraftPiston("N9253N", "Cessna 172"),
    new AircraftLockheedElectra("NR16020", "Lockheed Electra Model 10-E"),
    new AircraftAirbusA380("NR16020", "Superjumbo")
};

foreach (var aircraft in aircrafts)
{
    aircraft.FileFlightPlan();
    aircraft.StartEngines();
    aircraft.TakeOff();
    aircraft.Gear(false);
    aircraft.Gear(true);
    aircraft.Land();
    aircraft.StopEngines();
}