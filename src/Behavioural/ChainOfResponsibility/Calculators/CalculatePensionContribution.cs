using DesignPatterns.ChainOfResponsibility.Helpers;

namespace DesignPatterns.ChainOfResponsibility.Calculators;

public class CalculatePensionContribution : ICalculator<Employee>
{
    public async Task CalculateAsync(Employee employee)
    {
        var builder = new DeductionsBuilder();

        builder
            .AddBand(decimal.MaxValue, employee.PensionPercentage);

        var deductions = builder
            .Build(employee.GrossPayAnnual);

        employee.PensionContribution = MathHelper.Round(deductions.Sum(v => v.Value));

        await Task.CompletedTask;
    }
}