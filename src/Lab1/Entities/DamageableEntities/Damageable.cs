using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class Damageable : IDamageable
{
    public Damageable(double health, int id)
    {
        Health = health;
        Id = id;
    }

    private double Health { get; set; }
    private int Id { get; }

    public void GetDamaged(ISpaceObject spaceObject)
    {
        DamageEventResult result = spaceObject.GetDamage(Id, Health);
        if (result.WasDamaged)
        {
            Health -= result.DamagePointsLeft;
        }
    }
}