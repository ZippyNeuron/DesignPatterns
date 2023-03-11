namespace DesignPatterns.Visitor;

public class MemberStandard : Member
{
    public MemberStandard(string name, IMemberProcessor memberProcessor) : base(name)
    {
        memberProcessor.Visit(this);
    }
}