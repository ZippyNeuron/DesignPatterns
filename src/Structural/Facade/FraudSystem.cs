namespace DesignPatterns.Facade;

public class FraudSystem
{
    public bool Check(string cardNumber)
    {
        Console.WriteLine($"Card {cardNumber} has been fraud checked");
        return true;
    }
}