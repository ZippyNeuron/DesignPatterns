using DesignPatterns.ChainOfResponsibility.Helpers;

namespace DesignPatterns.ChainOfResponsibility.Calculators;

public class CalculateTax : ICalculator<Employee>
{
    public async Task CalculateAsync(Employee employee)
    {
        var builder = new DeductionsBuilder();

        builder
            .AddBand(12570m, 0m)
            .AddBand(50270m, 0.20m)
            .AddBand(150000m, 0.40m)
            .AddBand(decimal.MaxValue, 0.45m);

        var deductions = builder
            .Build(employee.GrossPayAnnual)
            .ToArray();
        
        employee.IncomeTax = MathHelper.Round(deductions.Sum(v => v.Value));
        
        employee.TaxableIncome = MathHelper.Round(
            deductions
                .Where(v => v.Percentage > 0)
                .Sum(v => v.Amount));

        await Task.CompletedTask;
    }
}