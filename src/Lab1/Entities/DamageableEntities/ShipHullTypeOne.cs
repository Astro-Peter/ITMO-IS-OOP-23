using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeOne : IShipHull
{
    public ShipHullTypeOne()
    {
        Health = 1;
    }

    private int Health { get; set; }

    public DamageEventResult GetDamaged(ISpaceObject spaceObject, int collisionNumber)
    {
        Health -= spaceObject.ClassOneHullDamage * collisionNumber;
        if (Health >= 0) return new DamageEventResult();
        int healthOverflow = -Health;
        Health = 0;
        return new DamageEventResult(false, healthOverflow);
    }

    public DamageEventResult AbsorbDamageOverflow(int damage)
    {
        Health -= damage;
        int healthOverflow = -Health;
        Health = 0;
        return healthOverflow < 0 ? new DamageEventResult() : new DamageEventResult(false, healthOverflow);
    }
}