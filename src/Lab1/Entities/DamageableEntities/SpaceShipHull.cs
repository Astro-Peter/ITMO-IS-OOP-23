using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;

public class SpaceShipHull : DamageableComponent
{
    public SpaceShipHull(int health)
        : base(health)
    {
    }
}