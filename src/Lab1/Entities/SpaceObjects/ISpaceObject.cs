using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public interface ISpaceObject
{
    public RouteCompletionResult CollisionResult { get; }
    public double DamageLeft { get; }
    public bool CheckIfDamageable(IDamageable damageable);
    public void GetDamaged(double damage);
    public ISpaceObject Copy();
}