using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities.ShipHulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Augur : SpaceShip
{
    public Augur(IPhotonDeflectors? photonDeflectors = null)
        : base(
            new ShipHullTypeThree(),
            new DeflectorsTypeThree(photonDeflectors),
            new ImpulseEngineE(WeightCategories.WeightClassHeavy),
            new AlphaJumpDrive(WeightCategories.WeightClassHeavy))
    {
        HasPhotonDeflectors = photonDeflectors;
    }

    private IPhotonDeflectors? HasPhotonDeflectors { get; }
    public override ISpaceShip Copy()
    {
        return new Augur(HasPhotonDeflectors?.Copy());
    }
}