namespace DesignPatterns.ChainOfResponsibility;

public interface IPaymentCalculator<in T>
{
    public void Calculate(T input);
}