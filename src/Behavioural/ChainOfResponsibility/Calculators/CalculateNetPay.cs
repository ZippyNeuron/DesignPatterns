using DesignPatterns.ChainOfResponsibility.Helpers;

namespace DesignPatterns.ChainOfResponsibility.Calculators;

public class CalculateNetPay : ICalculator<Employee>
{
    public async Task CalculateAsync(Employee employee)
    {
        employee.NetPayAnnual = MathHelper.Round(employee.GrossPayAnnual - (employee.IncomeTax + employee.NationalInsurance + employee.PensionContribution));
        employee.NetPayMonthly = MathHelper.Round(employee.NetPayAnnual / 12);

        await Task.CompletedTask;
    }
}