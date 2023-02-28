namespace DesignPatterns.Mediator;

public interface IController
{
    public bool RequestTakeOff(Aircraft aircraft);
    public void ReportTakeOff(Aircraft aircraft);
}