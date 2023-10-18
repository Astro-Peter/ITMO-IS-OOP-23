using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.ShipHulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Meridian : SpaceShip
{
    public Meridian(IPhotonDeflectors? photonDeflectors = null)
        : base(
            new ShipHullTypeTwo(),
            new DeflectorsTypeTwo(photonDeflectors),
            new ImpulseEngineE(WeightCategories.WeightClassMedium))
    {
        HasPhotonDeflectors = photonDeflectors;
    }

    private IPhotonDeflectors? HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Meridian(HasPhotonDeflectors?.Copy());
    }
}