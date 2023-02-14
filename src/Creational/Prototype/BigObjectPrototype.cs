namespace DesignPatterns.Prototype;

public abstract class BigObjectPrototype
{
    protected BigObjectPrototype(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public abstract BigObjectPrototype Clone();
}