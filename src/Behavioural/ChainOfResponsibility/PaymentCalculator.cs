using DesignPatterns.ChainOfResponsibility.Calculators;

namespace DesignPatterns.ChainOfResponsibility;

public abstract class PaymentCalculator<T> : IPaymentCalculator<T>
{
    private readonly IList<IEnumerable<ICalculator<T>>> _steps = new List<IEnumerable<ICalculator<T>>>();

    protected void AddCalculators(IEnumerable<ICalculator<T>> steps)
    {
        _steps.Add(steps);
    }
    
    public void Calculate(T input)
    {
        foreach (var steps in _steps)
        {
            var tasks = steps
                .Select(step => step.CalculateAsync(input));

            Task.WhenAll(tasks)
                .GetAwaiter()
                .GetResult();
        }
    }
}