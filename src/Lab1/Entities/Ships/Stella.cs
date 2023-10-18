using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.ShipHulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Stella : SpaceShip
{
    public Stella(IPhotonDeflectors? photonDeflectors = null)
        : base(
            new ShipHullTypeOne(),
            new DeflectorsTypeOne(photonDeflectors),
            new ImpulseEngineE(WeightCategories.WeightClassLight),
            new OmegaJumpDrive(WeightCategories.WeightClassLight))
    {
        HasPhotonDeflectors = photonDeflectors;
    }

    private IPhotonDeflectors? HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Stella(HasPhotonDeflectors?.Copy());
    }
}