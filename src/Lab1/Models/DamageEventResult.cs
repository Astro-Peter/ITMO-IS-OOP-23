namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class DamageEventResult
{
    public DamageEventResult(CollisionResult result, int damagePointsLeft)
    {
        Result = result;
        DamagePointsLeft = damagePointsLeft;
    }

    public CollisionResult Result { get; }
    public int DamagePointsLeft { get; }
}