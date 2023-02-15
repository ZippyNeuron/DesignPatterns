namespace Structural.Adapter;

public class ThirdPartyService : IThirdPartyService
{
    public void SendParameters(string param1, string param2, string param3)
    {
        Console.WriteLine($"Third Party Recieved Parameters: {param1} | {param2} | {param3}");
    }
}