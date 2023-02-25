namespace DesignPatterns.ChainOfResponsibility.Helpers;

public static class MathHelper
{
    public static decimal Round(decimal value)
    {
        return Math.Round(value, 2, MidpointRounding.AwayFromZero);
    }
}