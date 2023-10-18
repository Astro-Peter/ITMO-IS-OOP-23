using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceObjects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.ShipHulls;

public class ShipHull : IShipHull
{
    public ShipHull(double health)
    {
        Damageable = new Damageable(health);
    }

    private Damageable Damageable { get; }

    public void GetDamaged(ISpaceObject spaceObject)
    {
        if (spaceObject.CheckIfDamageable(this))
        {
            Damageable.GetDamaged(spaceObject);
        }
    }
}