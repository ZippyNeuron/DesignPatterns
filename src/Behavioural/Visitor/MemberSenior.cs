namespace DesignPatterns.Visitor;

public class MemberSenior : Member
{
    public MemberSenior(string name, IMemberProcessor memberProcessor) : base(name)
    {
        memberProcessor.Visit(this);
    }
}