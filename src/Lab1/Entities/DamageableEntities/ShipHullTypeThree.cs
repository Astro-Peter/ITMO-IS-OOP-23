using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeThree : IShipHull
{
    public ShipHullTypeThree()
    {
        Health = 20;
    }

    private int Health { get; set; }

    public DamageEventResult GetDamaged(ISpaceObject spaceObject, int collisionNumber)
    {
        Health -= spaceObject.ClassThreeHullDamage * collisionNumber;
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