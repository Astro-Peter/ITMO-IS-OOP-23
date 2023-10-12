namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DamageEventResult
{
    public DamageEventResult(bool operational = true, int damagePointsLeft = 0)
    {
        Operational = operational;
        DamagePointsLeft = damagePointsLeft;
    }

    public bool Operational { get; }
    public int DamagePointsLeft { get; }
}