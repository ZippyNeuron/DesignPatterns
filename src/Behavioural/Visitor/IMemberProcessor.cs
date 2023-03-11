namespace DesignPatterns.Visitor;

public interface IMemberProcessor
{
    public void Visit(MemberSenior member);
    
    public void Visit(MemberStandard member);
}