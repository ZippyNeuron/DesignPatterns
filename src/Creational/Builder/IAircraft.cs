namespace DesignPatterns.Builder;

public interface IAircraft
{
    public bool HasGear { get; set; }
    public bool HasRetractableGear { get; set;  }
    public bool HasAutopilot { get; set;  }
    public IList<IEngine> Engines { get; set; }
}