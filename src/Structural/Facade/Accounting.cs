namespace DesignPatterns.Facade;

public class Accounting : IAccounting
{
    public bool MakeCardPayment(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
        {
            return false;
        }
        
        var fraudSystem = new FraudSystem();
        
        if (!fraudSystem.Check(cardNumber))
        {
            return false;
        }
        
        var paymentSystem = new PaymentSystem();
        
        return paymentSystem.PayWith(cardNumber);
    }
}