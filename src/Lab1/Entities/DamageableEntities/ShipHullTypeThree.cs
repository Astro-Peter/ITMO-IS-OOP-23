namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class ShipHullTypeThree : Damageable
{
    private const int Health = 20;

    public ShipHullTypeThree()
        : base(Health, Id)
    {
    }

    public static int Id => 5;
}