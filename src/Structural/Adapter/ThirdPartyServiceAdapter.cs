namespace Structural.Adapter;

public class ThirdPartyServiceAdapter
{
    private readonly ThirdPartyService _thirdPartyService = new();

    public void Post(string clientMessage)
    {
        Console.WriteLine($"Adapter Processed Message: {clientMessage}");
        
        var parameters =
            clientMessage.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        if (parameters.Length != 3)
        {
            throw new ArgumentException("Invalid client message format", nameof(clientMessage));
        }
        
        _thirdPartyService.SendParameters(parameters[0], parameters[1], parameters[2]);
    }
}