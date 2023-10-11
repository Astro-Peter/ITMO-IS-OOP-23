using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class SpaceShipHull : DamageableComponent
{
    public SpaceShipHull(HullType type)
        : base((int)type) { }
}