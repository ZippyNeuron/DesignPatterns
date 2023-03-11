using DesignPatterns.Visitor;

var memberProcessor = new MemberProcessor();

var members = new List<Member>()
{
    new MemberStandard("Mark Twain", memberProcessor),
    new MemberSenior("Jane Twain", memberProcessor),
};
