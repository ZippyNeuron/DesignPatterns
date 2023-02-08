using AbstractFactory;

IAircraftBuilder aircraftBuilder = new AircraftBuilder(new JetAircraftFactory());

IAircraft aircraft = aircraftBuilder
    .AddEngines(EnginePosition.LeftWing, 1)
    .AddEngines(EnginePosition.RightWing, 1)
    .Build();