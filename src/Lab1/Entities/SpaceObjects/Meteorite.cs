using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class Meteorite : IRegularSpaceObject
{
    private const double DamageCoefficient = 2.5;
    public Meteorite(int collisionNumber)
    {
        DamageLeft = collisionNumber * DamageCoefficient;
    }

    public RouteCompletionResult CollisionResult => DamageLeft <= 0 ?
        RouteCompletionResult.Success : RouteCompletionResult.ShipDestroyed;

    public double DamageLeft { get; private set; }

    public bool CheckIfDamageable(IDamageable damageable)
    {
        return damageable is IProtectsFromRegularObjects;
    }

    public void GetDamaged(double damage)
    {
        DamageLeft -= damage;
    }

    public ISpaceObject Copy()
    {
        return new Meteorite((int)(DamageLeft / DamageCoefficient));
    }
}