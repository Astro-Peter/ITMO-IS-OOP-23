using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class SpaceWhale : IObjectInNeutrinoParticlesNebula
{
    private const double DamageCoefficient = 40;
    public SpaceWhale(int collisionNumber)
    {
        DamageLeft = collisionNumber * DamageCoefficient;
    }

    public RouteCompletionResult CollisionResult => DamageLeft <= 0 ?
        RouteCompletionResult.Success : RouteCompletionResult.ShipDestroyed;

    public double DamageLeft { get; private set; }

    public bool CheckIfDamageable(IDamageable damageable)
    {
        return damageable is IProtectsFromRegularObjects or IProtectsFromWhales;
    }

    public void GetDamaged(double damage)
    {
        DamageLeft -= damage;
    }

    public ISpaceObject Copy()
    {
        return new SpaceWhale((int)(DamageLeft / DamageCoefficient));
    }
}