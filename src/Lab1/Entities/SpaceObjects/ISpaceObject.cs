using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

public interface ISpaceObject
{
    public RouteCompletionResult CollisionResult { get; }
    public DamageEventResult GetDamage(int damageableId, double healthPoints);
}