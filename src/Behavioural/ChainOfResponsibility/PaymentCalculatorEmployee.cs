using DesignPatterns.ChainOfResponsibility.Calculators;

namespace DesignPatterns.ChainOfResponsibility;

public class PaymentCalculatorEmployee : PaymentCalculator<Employee>
{
    public PaymentCalculatorEmployee()
    {
        AddCalculators(new List<ICalculator<Employee>>()
        {
            new CalculateTax(),
            new CalculateNationalInsurance()
        });
        
        AddCalculators(new List<ICalculator<Employee>>()
        {
            new CalculatePensionContribution()
        });
        
        AddCalculators(new List<ICalculator<Employee>>()
        {
            new CalculateNetPay()
        });
    }
}