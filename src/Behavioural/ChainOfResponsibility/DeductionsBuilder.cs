using DesignPatterns.ChainOfResponsibility.Helpers;

namespace DesignPatterns.ChainOfResponsibility;

public class DeductionsBuilder
{
    private readonly List<(decimal band, decimal percent)> _bands = new();

    public DeductionsBuilder AddBand(decimal band, decimal percent)
    {
        if (_bands.Any() && band <= _bands.Max(b => b.band))
        {
            throw new ArgumentOutOfRangeException(nameof(band), "Band is lower than the current upper band");
        }

        _bands.Add((band, percent));

        return this;
    }

    public IEnumerable<Deduction> Build(decimal value)
    {
        return Enumerable
            .Range(0, _bands.Count)
            .Select(r =>
                {
                    var previousBand =
                        (r == 0) ? 0m : _bands[r - 1].band;

                    var amount =
                        (value > _bands[r].band)
                            ? _bands[r].band - previousBand
                            : Math.Clamp(value - previousBand, 0, decimal.MaxValue);

                    return new Deduction()
                    {
                        Band = _bands[r].band,
                        Amount = MathHelper.Round(amount),
                        Percentage = _bands[r].percent,
                        Value = MathHelper.Round(amount * _bands[r].percent)
                    };
                }
            );
    }
}