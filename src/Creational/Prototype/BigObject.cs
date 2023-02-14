namespace DesignPatterns.Prototype;

public class BigObject : BigObjectPrototype
{
    public BigObject(string name) : base(name)
    {
    }

    public override BigObjectPrototype Clone()
    {
        return (BigObjectPrototype)this.MemberwiseClone();
    }
}