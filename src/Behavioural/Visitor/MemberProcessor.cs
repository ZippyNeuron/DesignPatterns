namespace DesignPatterns.Visitor;

public class MemberProcessor : IMemberProcessor
{
    public void Visit(MemberSenior member)
    {
        Console.WriteLine($"The processor was visited by senior member {member.Name}");
    }

    public void Visit(MemberStandard member)
    {
        Console.WriteLine($"The processor was visited by member {member.Name}");
    }
}