using FactoryMethod;

AircraftFactory aircraftJetFactory = new AircraftJetFactory();
IAircraft jetAircraft = aircraftJetFactory.Create();

Console.WriteLine(jetAircraft.Name);

AircraftFactory aircraftPropellerFactory = new AircraftPropellerFactory();
IAircraft propellerAircraft = aircraftPropellerFactory.Create();

Console.WriteLine(propellerAircraft.Name);

AircraftFactory aircraftDefaultFactory = new AircraftDefaultFactory();
IAircraft defaultAircraft = aircraftDefaultFactory.Create();

Console.WriteLine(defaultAircraft.Name);