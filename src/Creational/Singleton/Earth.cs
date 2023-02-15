namespace Singleton;

public class Earth
{
    private static Earth? _instance;

    private Earth()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id;
    
    public static Earth Instance => _instance ??= new Earth();
}