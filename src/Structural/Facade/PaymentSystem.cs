namespace DesignPatterns.Facade;

public class PaymentSystem
{
    public bool PayWith(string cardNumber)
    {
        Console.WriteLine("Payment was successful");
        return true;
    }
}