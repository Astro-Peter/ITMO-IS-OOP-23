using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : SpaceShipWithDeflectors
{
    public Stella(IPhotonDeflectors? photonDeflectors)
        : base(
            new ShipHullTypeOne(),
            new DeflectorsTypeOne(photonDeflectors),
            new ImpulseEngineE(),
            WeightCategories.WeightClassLight,
            new OmegaJumpDrive())
    {
        HasPhotonDeflectors = photonDeflectors;
    }

    private IPhotonDeflectors? HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Stella(HasPhotonDeflectors?.Copy());
    }
}