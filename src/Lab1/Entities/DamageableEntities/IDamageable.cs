using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public interface IDamageable
{
    public DamageEventResult GetDamaged(ISpaceObject spaceObject, int collisionNumber);
    public DamageEventResult AbsorbDamageOverflow(int damage);
}