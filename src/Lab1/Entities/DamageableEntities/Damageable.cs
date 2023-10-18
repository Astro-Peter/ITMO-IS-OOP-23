using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class Damageable : IDamageable
{
    public Damageable(double health)
    {
        Health = health;
    }

    private double Health { get; set; }

    public void GetDamaged(ISpaceObject spaceObject)
    {
        double startHealth = Health;
        Health -= spaceObject.DamageLeft;
        if (Health >= 0)
        {
            spaceObject.GetDamaged(spaceObject.DamageLeft);
            return;
        }

        double result = startHealth;
        Health = 0;
        spaceObject.GetDamaged(result);
    }
}