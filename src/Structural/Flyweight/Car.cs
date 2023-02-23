namespace DesignPatterns.Flyweight;

public class Car
{
    public int NoOfDoors { get; set; }
    public bool Manual { get; set; }
    public int NoOfWheels { get; set; }
    public Engine? Engine { get; set; }
}