namespace DesignPatterns.ChainOfResponsibility.Calculators;

public interface ICalculator<in T>
{
    public Task CalculateAsync(T input);
}