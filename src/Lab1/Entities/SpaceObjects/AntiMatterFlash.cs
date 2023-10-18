using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public class AntiMatterFlash : IObjectInHighDensityNebula
{
    public AntiMatterFlash(int collisionNumber)
    {
        DamageLeft = collisionNumber;
    }

    public RouteCompletionResult CollisionResult => DamageLeft <= 0 ?
        RouteCompletionResult.Success : RouteCompletionResult.CrewLost;

    public double DamageLeft { get; private set; }

    public bool CheckIfDamageable(IDamageable damageable)
    {
        return damageable is IProtectsFromAntiMatterFlashes;
    }

    public void GetDamaged(double damage)
    {
        DamageLeft -= damage;
    }

    public ISpaceObject Copy()
    {
        return new AntiMatterFlash((int)DamageLeft);
    }
}