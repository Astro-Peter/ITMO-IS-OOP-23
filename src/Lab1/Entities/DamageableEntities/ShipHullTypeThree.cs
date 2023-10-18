namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeThree : ShipHull
{
    private const int Health = 20;

    public ShipHullTypeThree()
        : base(Health)
    {
    }
}