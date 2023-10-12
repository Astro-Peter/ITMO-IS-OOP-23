using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeTwo : IShipHull
{
    public ShipHullTypeTwo()
    {
        Health = 10;
    }

    private int Health { get; set; }

    public DamageEventResult GetDamaged(ISpaceObject spaceObject, int collisionNumber)
    {
        Health -= spaceObject.ClassTwoHullDamage * collisionNumber;
        if (Health >= 0) return new DamageEventResult();
        int healthOverflow = -Health;
        Health = 0;
        return new DamageEventResult(false, healthOverflow);
    }

    public DamageEventResult AbsorbDamageOverflow(int damage)
    {
        Health -= damage;
        if (Health >= 0) return new DamageEventResult();
        int healthOverflow = -Health;
        Health = 0;
        return new DamageEventResult(false, healthOverflow);
    }
}