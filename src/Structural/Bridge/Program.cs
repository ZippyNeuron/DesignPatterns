using DesignPatterns.Bridge;

var simulator1 = new Simulator(new SimulatorEngineOld());
simulator1.StartTheSimulatorEngine();

var simulator2 = new Simulator(new SimulatorEngineNew());
simulator2.StartTheSimulatorEngine();