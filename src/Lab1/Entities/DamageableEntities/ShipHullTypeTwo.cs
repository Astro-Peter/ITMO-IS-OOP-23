namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeTwo : Damageable
{
    private const int Health = 10;

    public ShipHullTypeTwo()
        : base(Health, Id)
    {
    }

    public static int Id => 4;
}