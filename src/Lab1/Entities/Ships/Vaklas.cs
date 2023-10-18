using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.ShipHulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Vaklas : SpaceShip
{
    public Vaklas(IPhotonDeflectors? photonDeflectors = null)
        : base(
            new ShipHullTypeTwo(),
            new DeflectorsTypeOne(photonDeflectors),
            new ImpulseEngineE(WeightCategories.WeightClassMedium),
            new GammaJumpDrive(WeightCategories.WeightClassMedium))
    {
        HasPhotonDeflectors = photonDeflectors;
    }

    private IPhotonDeflectors? HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Vaklas(HasPhotonDeflectors?.Copy());
    }
}