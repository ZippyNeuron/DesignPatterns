using AbstractFactory;

IAircraftBuilder aircraftBuilder = new AircraftBuilder(new JetAircraftFactory());

aircraftBuilder
    .AddEngines(EnginePosition.LeftWing, 1)
    .AddEngines(EnginePosition.RightWing, 1);