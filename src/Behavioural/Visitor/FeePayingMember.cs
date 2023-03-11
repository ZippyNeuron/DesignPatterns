namespace DesignPatterns.Visitor;

public abstract class Member
{
    public Member(string name)
    {
        Name = name;
    }
    
    public string Name { get; set; }
}