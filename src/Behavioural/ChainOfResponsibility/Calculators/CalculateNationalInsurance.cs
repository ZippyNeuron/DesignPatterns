using DesignPatterns.ChainOfResponsibility.Helpers;

namespace DesignPatterns.ChainOfResponsibility.Calculators;

public class CalculateNationalInsurance : ICalculator<Employee>
{
    public async Task CalculateAsync(Employee employee)
    {
        var builder = new DeductionsBuilder();

        builder
            .AddBand(242m * 52, 0m)
            .AddBand(967m * 52, 0.12m)
            .AddBand(decimal.MaxValue, 0.02m);

        var deductions = builder
            .Build(employee.GrossPayAnnual);

        employee.NationalInsurance = MathHelper.Round(deductions.Sum(v => v.Value));

        await Task.CompletedTask;
    }
}