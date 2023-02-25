namespace DesignPatterns.ChainOfResponsibility;

public class Employee
{
    public decimal GrossPayAnnual { get; init; }
    public decimal TaxableIncome { get; internal set; }
    public decimal IncomeTax { get; internal set; }
    public decimal NationalInsurance { get; internal set; }
    public decimal PensionPercentage { get; init; }
    public decimal PensionContribution { get; internal set; }
    public decimal TaxAllowance { get; init; }
    public decimal NetPayAnnual { get; internal set; }
    public decimal NetPayMonthly { get; internal set; }
}