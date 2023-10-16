namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeOne : Damageable
{
    private const int Health = 1;

    public ShipHullTypeOne()
        : base(Health, Id)
    {
    }

    public static int Id => 3;
}