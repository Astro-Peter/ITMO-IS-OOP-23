using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public interface IDamageable
{
    public void GetDamaged(ISpaceObject spaceObject);
}