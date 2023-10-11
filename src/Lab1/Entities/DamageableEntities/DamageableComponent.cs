using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class DamageableComponent
{
    private const int DamageOverflow = 2;

    public DamageableComponent(int healthPoints) => HealthPoints = healthPoints;

    private int HealthPoints { get; set; }

    public DamageEventResult GetDamaged(int damagePoints)
    {
        if (HealthPoints >= damagePoints)
        {
            HealthPoints -= damagePoints;
            return new DamageEventResult(CollisionResult.Operational, 0);
        }

        if (HealthPoints * DamageOverflow <= damagePoints)
        {
            HealthPoints = 0;
            return new DamageEventResult(CollisionResult.Disabled, 0);
        }

        damagePoints -= HealthPoints * DamageOverflow;
        HealthPoints = 0;
        return new DamageEventResult(CollisionResult.Destroyed, damagePoints);
    }
}