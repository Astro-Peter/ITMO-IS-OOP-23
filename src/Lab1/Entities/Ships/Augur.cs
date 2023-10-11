using Itmo.ObjectOrientedProgramming.Lab1.Entities.DamageableEntities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.ImpulseEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.JumpEngines;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Ships;

public class Augur : SpaceShipWithDeflectors
{
    public Augur(bool hasPhotonDeflectors)
        : base(
            HullType.TypeThree,
            DeflectorTypes.TypeThree,
            hasPhotonDeflectors,
            new ImpulseEngineE(),
            WeightCategories.WeightClassHeavy,
            new AlphaJumpDrive())
    {
        HasPhotonDeflectors = hasPhotonDeflectors;
    }

    private bool HasPhotonDeflectors { get; }

    public override ISpaceShip Copy()
    {
        return new Augur(HasPhotonDeflectors);
    }
}