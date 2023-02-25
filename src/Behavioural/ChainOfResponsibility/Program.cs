using System.Text.Json;
using DesignPatterns.ChainOfResponsibility;

var calculator = PaymentCalculatorFactory.Create();

var employee = new Employee()
{
    GrossPayAnnual = 60000m,
    TaxAllowance = 12570m,
    PensionPercentage = 0m
};

calculator.Calculate(employee);

Console.WriteLine(
    JsonSerializer.Serialize(
        employee,
        new JsonSerializerOptions() { WriteIndented = true }));