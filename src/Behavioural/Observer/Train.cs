namespace DesignPatterns.Observer;

public class Train : ITrain
{
    private readonly string _name;
    
    public Train(string name)
    {
        _name = name;
    }
    
    public void Go(bool go)
    {
        Console.WriteLine($"The {_name} train is {(go ? "GREEN" : "RED")}");
    }
}