using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Vaklas : SpaceShipWithDeflectors
{
    public Vaklas(IPhotonDeflectors? photonDeflectors)
        : base(
            new ShipHullTypeTwo(),
            new DeflectorsTypeOne(photonDeflectors),
            new ImpulseEngineE(),
            WeightCategories.WeightClassMedium,
            new GammaJumpDrive())
    {
        HasPhotonDeflectors = photonDeflectors;
    }

    private IPhotonDeflectors? HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Vaklas(HasPhotonDeflectors?.Copy());
    }
}