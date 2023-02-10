using System.Text.Json;
using DesignPatterns.Builder;

void Print(IAircraft aircraft) => Console.WriteLine(JsonSerializer.Serialize(aircraft, new JsonSerializerOptions() { WriteIndented = true }));

IAircraftBuilder aircraftBuilder = new AircraftBuilder();

var aircraft1 = aircraftBuilder
    .AddGear(true)
    .AddEngine(1, EnginePosition.Left)
    .AddEngine(2, EnginePosition.Right)
    .AddEngine(3, EnginePosition.Left)
    .AddEngine(4, EnginePosition.Right)
    .AddAutopilot()
    .Build();

Print(aircraft1);

var aircraftBuilderDirector = new AircraftBuilderDirector(aircraftBuilder.Reset());

aircraftBuilderDirector
    .BuildSingleEngineProp();
    
var aircraft2 = aircraftBuilder
    .Build();
    
Print(aircraft2);