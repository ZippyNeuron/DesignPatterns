namespace DesignPatterns.ChainOfResponsibility;

public static class PaymentCalculatorFactory
{
    public static IPaymentCalculator<Employee> Create() => new PaymentCalculatorEmployee();
}