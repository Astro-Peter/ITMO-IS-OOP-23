using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class TripShuttle : SpaceShip
{
    public TripShuttle()
    : base(
        new ShipHullTypeOne(),
        null,
        new ImpulseEngineC(WeightCategories.WeightClassLight))
    {
    }

    public override ISpaceShip Copy()
    {
        return new TripShuttle();
    }
}