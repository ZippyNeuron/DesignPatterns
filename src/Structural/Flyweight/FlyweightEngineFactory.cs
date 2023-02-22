namespace DesignPatterns.Flyweight;

public static class FlyweightEngineFactory
{
    private static readonly List<Engine> Engines = new();
    
    public static Engine Create(int cylinders, int bhp)
    {
        var engine = Engines
            .FirstOrDefault(e => e.Cylinders == cylinders && e.Bhp == bhp)
            ?? new Engine() { Cylinders = cylinders, Bhp = bhp };
        
        Engines.Add(engine);

        return engine;
    }
}