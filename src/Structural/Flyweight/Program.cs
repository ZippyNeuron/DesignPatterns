using DesignPatterns.Flyweight;

IList<Car> cars = new List<Car>();

for (var i = 0; i < 100; i++)
{
    cars.Add(new Car()
    {
        Manual = true,
        NoOfDoors = 4,
        NoOfWheels = 4,
        Engine = FlyweightEngineFactory.Create(4, 320)
    });
}

Console.WriteLine($"{cars.Count} Car objects created with flyweight engine references");
