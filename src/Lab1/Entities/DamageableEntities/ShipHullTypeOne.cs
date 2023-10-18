namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeOne : ShipHull
{
    private const int Health = 1;

    public ShipHullTypeOne()
        : base(Health)
    {
    }
}